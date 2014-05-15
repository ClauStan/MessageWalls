using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MessageWalls.Utils
{
    public enum MyRequestMethod
    {
        CreateUser,
        GetUser,
        AddWall,
        CreateMessage
    }

    class MyServerRequest
    {
        public delegate void OnRequestCompletedMethod(RequestUser requestUser, ResponseJson response);


        private static readonly bool USEDEVSERVER = false;

        private static readonly string CREATEUSER = "https://message-walls.appspot.com/createuser";
        private static readonly string GETUSER = "https://message-walls.appspot.com/getuser";
        private static readonly string ADDWALL = "https://message-walls.appspot.com/addwall";
        private static readonly string CREATEMESSAGE = "https://message-walls.appspot.com/createmessage";

        private static readonly string CREATEUSER_DEV = "http://localhost:14081/createuser";
        private static readonly string GETUSER_DEV = "http://localhost:14081/getuser";
        private static readonly string ADDWALL_DEV = "http://localhost:14081/addwall";
        private static readonly string CREATEMESSAGE_DEV = "http://localhost:14081/createmessage";

        public MyServerRequest()
        {

        }

        public void SendRequestToServer(MyRequestMethod requestMethod, RequestUser requestUser, OnRequestCompletedMethod method)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_Completed);
            Tuple<MyRequestMethod, RequestUser, OnRequestCompletedMethod> tuple = Tuple.Create<MyRequestMethod, RequestUser, OnRequestCompletedMethod>(requestMethod, requestUser, method);
            backgroundWorker.RunWorkerAsync(tuple); 
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Tuple<MyRequestMethod, RequestUser, OnRequestCompletedMethod> param = e.Argument as Tuple<MyRequestMethod, RequestUser, OnRequestCompletedMethod>;
            ResponseJson responseJson;

            try
            {
                string json;

                if (!JsonSerializer.Serialize(param.Item2, out json))
                {
                    responseJson = new ResponseJson();
                    responseJson.value = "fail";
                    responseJson.details = "Error while serializing request input json";
                    e.Result = Tuple.Create<RequestUser, ResponseJson, OnRequestCompletedMethod>(param.Item2, responseJson, param.Item3);
                    return;
                }

                string serverAdress = GetRequestAdress(param.Item1);
                HttpWebRequest webRequest = null;
                webRequest = (HttpWebRequest)WebRequest.Create(serverAdress);
                webRequest.ContentType = GetRequestContentType();
                webRequest.ContentLength = json.Length;
                webRequest.Method = GetRequestMethod(param.Item1);

                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();

                    var webResponse = (HttpWebResponse)webRequest.GetResponse();
                    using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        string response = streamReader.ReadToEnd();
                        if (!JsonSerializer.Deserialize<ResponseJson>(response, out responseJson))
                        {
                            responseJson = new ResponseJson();
                            responseJson.value = "fail";
                            responseJson.details = "Error while deserializing response output json";
                            e.Result = Tuple.Create<RequestUser, ResponseJson, OnRequestCompletedMethod>(param.Item2, responseJson, param.Item3);
                            return;
                        }

                        if (!responseJson.value.Equals("success") && !responseJson.value.Equals("fail"))
                        {
                            responseJson = new ResponseJson();
                            responseJson.value = "fail";
                            responseJson.details = "Wrong response json received from server";
                            e.Result = Tuple.Create<RequestUser, ResponseJson, OnRequestCompletedMethod>(param.Item2, responseJson, param.Item3);
                            return;
                        }

                        e.Result = Tuple.Create<RequestUser, ResponseJson, OnRequestCompletedMethod>(param.Item2, responseJson, param.Item3);
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                string error = exception.ToString();
                int pos = error.IndexOf("--->");
                if (pos != -1)
                {
                    error = error.Substring(0, pos);
                }

                responseJson = new ResponseJson();
                responseJson.value = "fail";
                responseJson.details = error;
                e.Result = Tuple.Create<RequestUser, ResponseJson, OnRequestCompletedMethod>(param.Item2, responseJson, param.Item3);
                return;
            }
        }

        void backgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<RequestUser, ResponseJson, OnRequestCompletedMethod> param = e.Result as Tuple<RequestUser, ResponseJson, OnRequestCompletedMethod>;
            //call the OnRequestCompletedMethod delegate received as input
            param.Item3(param.Item1, param.Item2);
        }

        private string GetRequestAdress(MyRequestMethod request)
        {
            if (request == MyRequestMethod.CreateUser)
            {
                if (USEDEVSERVER) return CREATEUSER_DEV;
                else return CREATEUSER;
            }

            if (request == MyRequestMethod.GetUser)
            {
                if (USEDEVSERVER) return GETUSER_DEV;
                else return GETUSER;
            }

            if (request == MyRequestMethod.AddWall)
            {
                if (USEDEVSERVER) return ADDWALL_DEV;
                else return ADDWALL;
            }

            if (request == MyRequestMethod.CreateMessage)
            {
                if (USEDEVSERVER) return CREATEMESSAGE_DEV;
                else return CREATEMESSAGE;
            }

            return "";
        }

        private string GetRequestContentType()
        {
            if (USEDEVSERVER)
            {
                return "application/x-www-form-urlencoded";                
            }
            else
            {
                return "text/json";
            }
        }

        private string GetRequestMethod(MyRequestMethod request)
        {
            return "POST";
        }

    }
}
