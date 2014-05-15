using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.View
{
    interface ICreateUserView : IChildView
    {
        string Username { get; set; }
        string DisplayName { get; set; }
        string Password { get; set; }
        string RePassword { get; set; }
        bool CreateLoadingVisible { get; set; }
        string ErrorText { get; set; }

        void SetUsernameFocus();

        event EventHandler CreateUserClicked;
        event EventHandler GoToLoginUserClicked;
    }
}
