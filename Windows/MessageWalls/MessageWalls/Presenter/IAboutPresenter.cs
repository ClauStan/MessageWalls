using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Presenter
{
    interface IAboutPresenter : IPresenter
    {
        void OnAuthorWebLinkClicked(object sender, System.EventArgs e);
        void OnCodeWebLinkClicked(object sender, System.EventArgs e);
        void OnGoToPreviousView(object sender, System.EventArgs e);
    }
}
