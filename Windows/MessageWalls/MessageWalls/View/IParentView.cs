using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.View
{
    interface IParentView
    {
        string Title { get; set; }
        IChildView CurrentChildView { get; set; }
        bool IsVisible { get; set; }

        void ShowNotification(string text);

        event EventHandler InvertVisibility;
        event EventHandler ExitClicked;
        event EventHandler SettingsClicked;
        event EventHandler AboutClicked;
    }
}
