using MessageWalls.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Model
{
    class DataModel : IDataModel
    {
        private User userModel;
        private MySettings settings;

        public DataModel()
        {
            userModel = new Utils.User();
            settings = new MySettings();
        }

        public MySettings Settings 
        {
            get { return settings; }
            set { settings = (MySettings)value; }
        }

        public User User 
        {
            get { return userModel; }
            set { userModel = value; }
        }
        
        public void MergeUserModel(User user)
        {
            if (user.date != null)
            {
                userModel.date = user.date;
            }

            if (user.walls != null)
            {
                if (userModel.walls == null)
                {
                    userModel.walls = new List<Wall>();
                }

                foreach (Wall wall in user.walls)
                {
                    Wall foundWall = WallExists(wall.name);
                    if (foundWall != null)
                    {
                        if (foundWall.messages == null)
                        {
                            foundWall.messages = new List<Message>();
                            continue;
                        }

                        foreach (Message mess in wall.messages)
                        {
                            if(!MessageExists(foundWall, mess.id))
                            {
                                foundWall.messages.Add(mess);
                            }
                        }
                    }
                    else
                    {                       
                        userModel.walls.Add(wall);
                    }
                }
            }
        }

        public Wall MergeAndReturnWallChanges(User user, string returnWallName)
        {
            Wall returnWall = new Wall();
            returnWall.messages = new List<Message>();

            if (user.date != null)
            {
                userModel.date = user.date;
            }

            if (user.walls != null)
            {
                if (userModel.walls == null)
                {
                    userModel.walls = new List<Wall>();
                }

                foreach (Wall wall in user.walls)
                {
                    Wall foundWall = WallExists(wall.name);
                    if (foundWall != null)
                    {
                        if (foundWall.messages == null)
                        {
                            foundWall.messages = new List<Message>();
                        }

                        bool addMessage = false;
                        if(wall.name.Equals(returnWallName))
                        {
                            addMessage = true;
                        }

                        if (wall.messages == null)
                        {
                            foundWall.messages = new List<Message>();
                            continue;
                        }

                        foreach (Message mess in wall.messages)
                        {
                            if (!MessageExists(foundWall, mess.id))
                            {
                                foundWall.messages.Add(mess);
                                if (addMessage)
                                {
                                    returnWall.messages.Add(mess);
                                }
                            }
                        }
                    }
                    else
                    {
                        userModel.walls.Add(wall);
                    }
                }
            }

            return returnWall;
        }

        // returns a wall with a certain name if it exists
        public Wall GetWallByName(string name)
        {
            foreach (Wall wall in userModel.walls)
            {
                if (wall.name.Equals(name))
                {
                    return wall;
                }
            }

            return null;
        }

        // returns a wall on a certain position if it exists
        public Wall GetWallByPos(int pos)
        {
            if (userModel.walls != null || pos < 0 || pos > userModel.walls.Count - 1)
            {
                return null;
            }

            return userModel.walls[pos];
        }

        public List<string> GetAllWallNames()
        {
            List<string> wallNames = new List<string>();
            if (userModel.walls != null)
            {
                foreach (Wall wall in userModel.walls)
                {
                    wallNames.Add(wall.name);
                }
            }

            return wallNames;
        }

        public void LoadDataModel()
        {
            Properties.Settings.Default.Reload();

            settings.RefreshMinutes = Properties.Settings.Default.RefreshMinutes;
            settings.RefreshSeconds = Properties.Settings.Default.RefreshSeconds;
            settings.ShowNotifications = Properties.Settings.Default.ShowNotifications;
            settings.RememberUser = Properties.Settings.Default.RememberUser;

            if (settings.RememberUser)
            {
                userModel.username = Properties.Settings.Default.Username;
                userModel.password = Properties.Settings.Default.PasswordHash;

                User userInfo;
                string userInfoString = Properties.Settings.Default.UserInfo;
                if (!string.IsNullOrEmpty(userInfoString) && !string.IsNullOrEmpty(userModel.username))
                {
                    string userInfoJson = Crypto.DecryptStringAES(userInfoString, userModel.username);
                    if (JsonSerializer.Deserialize<User>(userInfoJson, out userInfo))
                    {
                        userModel.walls = userInfo.walls;
                        //copy the last update date so that the next update will skip old messages
                        userModel.date = userInfo.date;
                    }
                }
            }
        }

        public void SaveDataModel()
        {
            Properties.Settings.Default.RefreshMinutes = settings.RefreshMinutes;
            Properties.Settings.Default.RefreshSeconds = settings.RefreshSeconds;
            Properties.Settings.Default.ShowNotifications = settings.ShowNotifications;
            Properties.Settings.Default.RememberUser = settings.RememberUser;

            if (settings.RememberUser)
            {
                Properties.Settings.Default.Username = userModel.username;
                //dont hash an already hashed password
                if (Properties.Settings.Default.PasswordHash != userModel.password)
                {
                    Properties.Settings.Default.PasswordHash = Crypto.ComputeHash(userModel.password);
                }

                User userInfo = new User();
                userInfo.walls = userModel.walls;
                string userInfoString;
                if (JsonSerializer.Serialize<User>(userInfo, out userInfoString))
                {
                    if (!string.IsNullOrEmpty(userInfoString) && !string.IsNullOrEmpty(userModel.username))
                    {
                        Properties.Settings.Default.UserInfo = Crypto.EncryptStringAES(userInfoString, userModel.username);
                    }
                }
            }

            Properties.Settings.Default.Save();
        }


        private Wall WallExists(string name)
        {
            if (userModel.walls != null)
            {
                foreach (Wall wall in userModel.walls)
                {
                    if (wall.name.Equals(name))
                    {
                        return wall;
                    }
                }
            }

            return null;
        }

        private bool MessageExists(Wall wall, string id)
        {
            if (wall != null && wall.messages != null)
            {
                foreach (Message mess in wall.messages)
                {
                    if (mess.id.Equals(id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
