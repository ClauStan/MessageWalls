using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.View
{
    interface ILoginUserView : IChildView
    {
        string Username { get; set; }
        string Password { get; set; }
        bool RememberUser { get; set; }
        bool LoginOfflineVisible { get; set; }
        bool LoginLoadingVisible { get; set; }
        string ErrorText { get; set; }

        void SetUsernameFocus();
        void SetPasswordFocus();

        event EventHandler LoginUserClicked;
        event EventHandler LoginUserOfflineClicked;
        event EventHandler GoToCreateUserClicked;
        event EventHandler LoginUsernameChanged;
    }
}
