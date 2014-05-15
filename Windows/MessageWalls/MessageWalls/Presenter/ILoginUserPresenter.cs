using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Presenter
{
    interface ILoginUserPresenter : IPresenter
    {
        void OnLoginUserClicked(object sender, System.EventArgs e);
        void OnLoginUserOfflineClicked(object sender, System.EventArgs e);
        void OnGoToCreateUserClicked(object sender, System.EventArgs e);
    }
}
