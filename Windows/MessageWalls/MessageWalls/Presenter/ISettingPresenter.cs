using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Presenter
{
    interface ISettingPresenter : IPresenter
    {
        void OnShowNotificationChanged(object sender, System.EventArgs e);
        void OnRefreshMinutesChanged(object sender, System.EventArgs e);
        void OnRefreshSecondsChanged(object sender, System.EventArgs e);
        void OnGoToPreviousView(object sender, System.EventArgs e);
    }
}
