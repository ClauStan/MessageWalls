using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Presenter
{
    interface IWallPresenter : IPresenter
    {
        void OnNewWallClicked(object sender, System.EventArgs e);
        void OnNewMessageClicked(object sender, System.EventArgs e);
        void OnNewWallSelected(object sender, System.EventArgs e);
        void OnRefreshWallsClicked(object sender, System.EventArgs e);
    }
}
