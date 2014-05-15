using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Presenter
{
    interface IParentPresenter : ILoginUserPresenter, ICreateUserPresenter, IWallPresenter, ISettingPresenter, IAboutPresenter
    {
        void OnInvertVisibility(object sender, System.EventArgs e);
        void OnSettingsClicked(object sender, System.EventArgs e);
        void OnAboutClicked(object sender, System.EventArgs e);
        void OnExitClicked(object sender, System.EventArgs e);
    }
}
