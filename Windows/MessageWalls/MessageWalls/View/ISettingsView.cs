using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.View
{
    interface ISettingsView : IChildView
    {
        int RefreshMinutes { get; set; }
        int RefreshSeconds { get; set; }
        bool ShowNotifications { get; set; }

        event EventHandler ShowNotificationChanged;
        event EventHandler RefreshMinutesChanged;
        event EventHandler RefreshSecondsChanged;
        event EventHandler GoToPreviousView;
    }
}
