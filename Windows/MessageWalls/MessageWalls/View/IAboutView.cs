using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.View
{
    interface IAboutView : IChildView
    {
        event EventHandler AuthorWebLinkClicked;
        event EventHandler CodeWebLinkClicked;
        event EventHandler GoToPreviousView;
    }
}
