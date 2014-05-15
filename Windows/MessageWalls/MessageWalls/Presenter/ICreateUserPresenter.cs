using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Presenter
{
    interface ICreateUserPresenter : IPresenter
    {
        void OnCreateUserClicked(object sender, System.EventArgs e);
        void OnGoToLoginUserClicked(object sender, System.EventArgs e);
    }
}
