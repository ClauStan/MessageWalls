using MessageWalls.Model;
using MessageWalls.Utils;
using MessageWalls.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace MessageWalls.Presenter
{
    class ParentPresenter : IParentPresenter
    {
        IDataModel dataModel;

        IParentView parentView;                
        ILoginUserView loginUserView;
        ICreateUserView createUserView;
        IWallView wallView;
        ISettingsView settingView;
        IAboutView aboutView;

        MyServerRequest serverRequest;
        IChildView previousView;

        public ParentPresenter(IDataModel dataModel, IParentView parentView, ILoginUserView loginUserView, ICreateUserView createUserView, IWallView wallView, ISettingsView settingView, IAboutView aboutView)
        {
            serverRequest = new MyServerRequest();

            this.dataModel = dataModel;

            this.parentView = parentView;
            this.parentView.InvertVisibility += this.OnInvertVisibility;
            this.parentView.SettingsClicked += this.OnSettingsClicked;
            this.parentView.AboutClicked += this.OnAboutClicked;
            this.parentView.ExitClicked += this.OnExitClicked;

            this.loginUserView = loginUserView;
            this.loginUserView.LoginUserClicked += this.OnLoginUserClicked;
            this.loginUserView.LoginUserOfflineClicked += this.OnLoginUserOfflineClicked;
            this.loginUserView.GoToCreateUserClicked += this.OnGoToCreateUserClicked;
            this.loginUserView.LoginUsernameChanged += this.OnLoginUsernameChanged;

            this.createUserView = createUserView;
            this.createUserView.CreateUserClicked += this.OnCreateUserClicked;
            this.createUserView.GoToLoginUserClicked += this.OnGoToLoginUserClicked;

            this.wallView = wallView;
            this.wallView.NewWallClicked += this.OnNewWallClicked;
            this.wallView.NewMessageClicked += this.OnNewMessageClicked;
            this.wallView.NewWallSelected += this.OnNewWallSelected;
            this.wallView.RefreshWallsClicked += this.OnRefreshWallsClicked;
            this.wallView.WallsAutoRefresh += this.OnRefreshWallsClicked;

            this.settingView = settingView;
            this.settingView.ShowNotificationChanged += this.OnShowNotificationChanged;
            this.settingView.RefreshMinutesChanged += this.OnRefreshMinutesChanged;
            this.settingView.RefreshSecondsChanged += this.OnRefreshSecondsChanged;
            this.settingView.GoToPreviousView += this.OnGoToPreviousView;

            this.aboutView = aboutView;
            this.aboutView.GoToPreviousView += this.OnGoToPreviousView;
            this.aboutView.AuthorWebLinkClicked += this.OnAuthorWebLinkClicked;
            this.aboutView.CodeWebLinkClicked += this.OnCodeWebLinkClicked;
            
            //load model data
            dataModel.LoadDataModel();

            //set settings on loginView
            if (dataModel.Settings.RememberUser)
            {
                loginUserView.RememberUser = true;
                if (!string.IsNullOrEmpty(dataModel.User.username))
                {
                    loginUserView.Username = dataModel.User.username;
                    loginUserView.LoginOfflineVisible = true;
                    loginUserView.SetPasswordFocus();
                }
                else
                {
                    loginUserView.SetUsernameFocus();
                }
            }
            else
            {
                loginUserView.RememberUser = false;
                loginUserView.SetUsernameFocus();
            }

            //load loginUSerView
            parentView.CurrentChildView = this.loginUserView;
        }

        //Methods from IParentPresenter//
        public void OnInvertVisibility(object sender, System.EventArgs e)
        {
            if (parentView.IsVisible)
            {
                parentView.IsVisible = false;
                parentView.ShowNotification("Message Walls has minimized to tray!");
            }
            else
            {
                parentView.IsVisible = true;                
            }
        }

        public void OnSettingsClicked(object sender, System.EventArgs e)
        {
            //save current View so that the back button from SettingsView know where to return
            previousView = parentView.CurrentChildView;
            //set current settings
            settingView.RefreshMinutes = dataModel.Settings.RefreshMinutes;
            settingView.RefreshSeconds = dataModel.Settings.RefreshSeconds;
            settingView.ShowNotifications = dataModel.Settings.ShowNotifications;
            //show Settings View
            parentView.CurrentChildView = settingView;
        }

        public void OnAboutClicked(object sender, System.EventArgs e)
        {
            //save current View so that the back button from AboutView know where to return
            previousView = parentView.CurrentChildView;
            //show About View
            parentView.CurrentChildView = aboutView;
        }

        public void OnExitClicked(object sender, System.EventArgs e)
        {
            //save user model before exit
            dataModel.SaveDataModel();
        }
        ////////////////////////////////////

        //Methods from ILoginUserPresenter//
        public void OnLoginUserClicked(object sender, System.EventArgs e)
        {
            if (IsUserLoginValid())
            {
                //make visible the loading bar while retrieving data from server
                loginUserView.LoginLoadingVisible = true;

                RequestUser userRequest = new RequestUser();
                userRequest.username = loginUserView.Username;
                userRequest.password = loginUserView.Password;

                //send request to server
                serverRequest.SendRequestToServer(MyRequestMethod.GetUser, userRequest, OnLoginUserCompleted);
            }
        }

        public void OnLoginUserOfflineClicked(object sender, System.EventArgs e)
        {
            if (IsUserLoginValid())
            {
                //if user credentials match offline data
                if (IsOfflinePasswordMatching())
                {
                    //add offline wall data to the wall view 
                    PopulateWallView();

                    //deactivate all buttons
                    wallView.AddNewMessageEnabled = false;
                    wallView.AddNewWallEnabled = false;
                    wallView.RefreshEnabled = false;

                    parentView.Title = "MessageWalls - Offline Mode";

                    //load wallView
                    parentView.CurrentChildView = wallView;
                }
            }
        }

        public void OnGoToCreateUserClicked(object sender, System.EventArgs e)
        {
            parentView.CurrentChildView = createUserView;

            //reset values on loginUserView
            loginUserView.Password = "";
            loginUserView.ErrorText = "";   
        }

        public void OnLoginUsernameChanged(object sender, System.EventArgs e)
        {
            if (dataModel.Settings.RememberUser)
            {
                if (loginUserView.Username == dataModel.User.username)
                {
                    loginUserView.LoginOfflineVisible = true;
                }
                else
                {
                    loginUserView.LoginOfflineVisible = false;
                }

            }
        }
        ////////////////////////////////////

        //Methods from ICreateUserPresenter//
        public void OnCreateUserClicked(object sender, System.EventArgs e)
        {
            if (IsUserCreateValid())
            {
                createUserView.CreateLoadingVisible = true;

                RequestUser userRequest = new RequestUser();
                userRequest.username = createUserView.Username;
                userRequest.password = createUserView.Password;
                userRequest.name = createUserView.DisplayName;

                //send request to server
                serverRequest.SendRequestToServer(MyRequestMethod.CreateUser, userRequest, OnCreateUserCompleted);
            }
        }

        public void OnGoToLoginUserClicked(object sender, System.EventArgs e)
        {
            parentView.CurrentChildView = loginUserView;

            //reset values on createUserView
            createUserView.Username = "";
            createUserView.DisplayName = "";
            createUserView.Password = "";
            createUserView.RePassword = "";
            createUserView.ErrorText = "";
        }
        ////////////////////////////////////

        //Methods from IWallPresenter//
        public void OnNewWallClicked(object sender, System.EventArgs e)
        {
            if (IsNewWallValid())
            {
                RequestUser userRequest = new RequestUser();
                userRequest.username = dataModel.User.username;
                userRequest.password = dataModel.User.password;
                userRequest.name = wallView.NewWallNameText;

                //send request to server
                serverRequest.SendRequestToServer(MyRequestMethod.AddWall, userRequest, OnAddWallCompleted);
            }

            wallView.SetNewMessageFocus();
        }

        public void OnNewMessageClicked(object sender, System.EventArgs e)
        {
            if (IsNewMessageValid())
            {
                RequestUser userRequest = new RequestUser();
                userRequest.username = dataModel.User.username;
                userRequest.password = dataModel.User.password;
                userRequest.name = wallView.SelectedWall;
                userRequest.content = wallView.NewMessageText;

                //send request to server
                serverRequest.SendRequestToServer(MyRequestMethod.CreateMessage, userRequest, OnAddMessageCompleted);
            }

            wallView.SetNewMessageFocus();
        }

        public void OnRefreshWallsClicked(object sender, System.EventArgs e)
        {
            RequestUser userRequest = new RequestUser();
            userRequest.username = dataModel.User.username;
            userRequest.password = dataModel.User.password;
            userRequest.date = dataModel.User.date;

            serverRequest.SendRequestToServer(MyRequestMethod.GetUser, userRequest, OnRefreshWallsCompleted);
        }

        public void OnNewWallSelected(object sender, System.EventArgs e)
        {
            wallView.ResetMessages();

            string wallName = wallView.SelectedWall;
            Wall selectedWall = (Wall)dataModel.GetWallByName(wallName);

            if(selectedWall != null && selectedWall.messages != null)
            {
                foreach (Message mess in selectedWall.messages)
                {
                    wallView.AddMessageToSelectedWall(mess.content, mess.author, mess.date);
                }
            }
        }
        ////////////////////////////////////

        //Methods from ISettingPresenter//
        public void OnShowNotificationChanged(object sender, System.EventArgs e)
        {
            dataModel.Settings.ShowNotifications = settingView.ShowNotifications;
        }

        public void OnRefreshMinutesChanged(object sender, System.EventArgs e)
        {
            dataModel.Settings.RefreshMinutes = settingView.RefreshMinutes;
            wallView.AutoRefreshInterval = (dataModel.Settings.RefreshMinutes * 60 + dataModel.Settings.RefreshSeconds) * 1000;
        }

        public void OnRefreshSecondsChanged(object sender, System.EventArgs e)
        {
            dataModel.Settings.RefreshSeconds = settingView.RefreshSeconds;
            wallView.AutoRefreshInterval = (dataModel.Settings.RefreshMinutes * 60 + dataModel.Settings.RefreshSeconds) * 1000;
        }

        //also used in IAboutPresenter
        public void OnGoToPreviousView(object sender, System.EventArgs e)
        {
            //go to previous view
            parentView.CurrentChildView = previousView;
        }
        ////////////////////////////////////

        //Methods from IAboutPresenter//
        public void OnAuthorWebLinkClicked(object sender, System.EventArgs e)
        {
            ProcessStartInfo authorSiteProcess = new ProcessStartInfo("http://thecodewhereisit.appspot.com");
            Process.Start(authorSiteProcess);
        }

        public void OnCodeWebLinkClicked(object sender, System.EventArgs e)
        {
            ProcessStartInfo codeSiteProcess = new ProcessStartInfo("https://github.com/ClauStan");
            Process.Start(codeSiteProcess);
        }
        ////////////////////////////////////

        //Private methods
        private bool IsUserLoginValid()
        {
            if (loginUserView.Username.Length < 4)
            {
                loginUserView.ErrorText = "Username is less than 4 characters";
                return false;
            }
            if (loginUserView.Password.Length < 4)
            {
                loginUserView.ErrorText = "Password is less than 4 characters";
                return false;
            }

            loginUserView.ErrorText = "";
            return true;
        }

        private bool IsOfflinePasswordMatching()
        {
            string passwordHash = Crypto.ComputeHash(loginUserView.Password);

            //if user credentials match offline data
            if (passwordHash != dataModel.User.password)
            {
                loginUserView.ErrorText = "Offline password does not match";
                return false;
            }

            loginUserView.ErrorText = "";
            return true;
        }

        private bool IsUserCreateValid()
        {
            if (createUserView.Username.Length < 4)
            {
                createUserView.ErrorText = "Username is less than 4 characters";
                return false;
            }
            if (createUserView.DisplayName.Length < 4)
            {
                createUserView.ErrorText = "Display name is less than 4 characters";
                return false;
            }
            if (createUserView.Password.Length < 4)
            {
                createUserView.ErrorText = "Password is less than 4 characters";
                return false;
            }
            if (createUserView.Password != createUserView.RePassword)
            {
                createUserView.ErrorText = "Password and Retype Password do not match";
                return false;
            }

            createUserView.ErrorText = "";
            return true;
        }

        private bool IsNewWallValid()
        {
            if (wallView.NewWallNameText.Length == 0)
            {
                wallView.ErrorText = "Cannot create empty message walls";
                return false;
            }

            wallView.ErrorText = "";
            return true;
        }

        private bool IsNewMessageValid()
        {
            if (wallView.NewMessageText.Length == 0)
            {
                wallView.ErrorText = "Cannot send empty messages";
                return false;
            }

            wallView.ErrorText = "";
            return true;
        }

        private void PopulateWallView()
        {
            List<string> wallNames = dataModel.GetAllWallNames();
            foreach (string wallName in wallNames)
            {
                wallView.AddNewWallName(wallName);
            }

            if (wallNames.Count > 0)
            {
                wallView.SelectWallByPos(0);
            }
        }

        private void OnLoginUserCompleted(RequestUser userRequest, ResponseJson response)
        {
            if (response.value.Equals("success"))
            {
                //reset text error
                loginUserView.ErrorText = "";

                //create login user - response request doesn't contain usernames or passwords
                User loginUser = response.user;
                loginUser.username = userRequest.username;
                loginUser.password = userRequest.password;

                //save new user data in model
                dataModel.User = loginUser;

                //set new user data to wallView
                PopulateWallView();

                //load wallView
                parentView.CurrentChildView = wallView;
                wallView.AutoRefreshWorking = true;
            }
            else if (response.value.Equals("fail"))
            {
                loginUserView.ErrorText = response.details;
            }
            else
            {
                loginUserView.ErrorText = "Unexpected error";
            }
        }

        private void OnCreateUserCompleted(RequestUser userRequest, ResponseJson response)
        {
            if (response.value.Equals("success"))
            {
                //reset text error
                createUserView.ErrorText = "";

                //create new user - response request doesn't contain usernames or passwords
                User createdUser = new User();
                createdUser.username = userRequest.username;
                createdUser.password = userRequest.password;
                createdUser.name = userRequest.name;

                //save new user data in model
                dataModel.User = createdUser;

                //load wallView
                parentView.CurrentChildView = wallView;
                wallView.AutoRefreshWorking = true;
            }
            else if (response.value.Equals("fail"))
            {
                createUserView.ErrorText = response.details;
            }
            else
            {
                createUserView.ErrorText = "Unexpected error";
            }
        }

        private void OnAddWallCompleted(RequestUser userRequest, ResponseJson response)
        {
            if (response.value.Equals("success"))
            {
                //reset text error
                wallView.ErrorText = "";

                //save new user data in model
                dataModel.MergeUserModel(response.user);

                if (response.user.walls != null && response.user.walls.Count > 0)
                {
                    wallView.AddNewWallName(response.user.walls[0].name);
                    wallView.SelectedWall = response.user.walls[0].name;
                }               

                //wallView.NewWallNameText = "";
            }
            else if (response.value.Equals("fail"))
            {
                wallView.ErrorText = response.details;
            }
            else
            {
                wallView.ErrorText = "Unexpected error";
            }
        }

        private void OnAddMessageCompleted(RequestUser userRequest, ResponseJson response)
        {
            if (response.value.Equals("success"))
            {
                //reset text error
                wallView.ErrorText = "";

                //save new user data in model
                dataModel.MergeUserModel(response.user);

                if (userRequest.name.Equals(wallView.SelectedWall))
                {
                    if (response.user.walls != null && response.user.walls.Count > 0 && response.user.walls[0].messages != null && response.user.walls[0].messages.Count > 0)
                    {
                        Message mess = response.user.walls[0].messages[0];
                        wallView.AddMessageToSelectedWall(mess.content, mess.author, mess.date);
                    }
                }

                wallView.NewMessageText = "";
            }
            else if (response.value.Equals("fail"))
            {
                wallView.ErrorText = response.details;
            }
            else
            {
                wallView.ErrorText = "Unexpected error";
            }
        }

        private void ManageNewMessagesNotification(User responseUser)
        {
            if (dataModel.Settings.ShowNotifications)
            {
                int nrNewMessages = 0;
                int nrWallsChanged = 0;
                string lastWallName = "";
                string notificationMessage = "";

                //calculate how many new messages
                if (responseUser.walls != null)
                {
                    foreach (Wall wall in responseUser.walls)
                    {
                        if (wall.messages != null)
                        {
                            if (wall.messages.Count > 0)
                            {
                                int nrOfMessagesFromOthers = 0;
                                foreach (Message mess in wall.messages)
                                {
                                    if (mess.author != dataModel.User.name)
                                    {
                                        nrOfMessagesFromOthers++;
                                    }
                                }

                                if (nrOfMessagesFromOthers > 0)
                                {
                                    nrWallsChanged++;
                                    lastWallName = wall.name;
                                    nrNewMessages += nrOfMessagesFromOthers;
                                }
                            }
                        }
                    }
                }

                //create notification message
                if(nrNewMessages > 0)
                {
                    if (nrNewMessages > 1)
                    {
                        notificationMessage += nrNewMessages.ToString() + " new messages on ";
                        if (nrWallsChanged > 1)
                        {
                            notificationMessage += lastWallName + " and other ";
                            if (nrWallsChanged > 2)
                            {
                                notificationMessage += (nrWallsChanged - 1).ToString() + " walls";
                            }
                            else
                            {
                                notificationMessage += "1 wall";
                            }
                        }
                        else
                        {
                            notificationMessage += lastWallName + " wall";
                        }
                    }
                    else
                    {
                        notificationMessage += "1 new message on " + lastWallName+" wall";
                    }

                    //show notification
                    parentView.ShowNotification(notificationMessage);
                }
            }
        }

        private void OnRefreshWallsCompleted(RequestUser userRequest, ResponseJson response)
        {
            if (response.value.Equals("success"))
            {
                //reset text error
                wallView.ErrorText = "";

                //save new user data in model
                string selectedWallName = wallView.SelectedWall;
                Wall selectedWallChanges = dataModel.MergeAndReturnWallChanges(response.user, selectedWallName);

                //add new messages on the selected wall if any
                foreach (Message mess in selectedWallChanges.messages)
                {
                    wallView.AddMessageToSelectedWall(mess.content, mess.author, mess.date);
                }

                //create new notifications
                ManageNewMessagesNotification(response.user);
            }
            else if (response.value.Equals("fail"))
            {
                wallView.ErrorText = response.details;
            }
            else
            {
                wallView.ErrorText = "Unexpected error";
            }
        }
    }
}
