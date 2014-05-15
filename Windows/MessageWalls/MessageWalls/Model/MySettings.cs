using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Model
{
    class MySettings
    {
        public MySettings()
        {
            RememberUser = true;
            RefreshMinutes = 0;
            RefreshSeconds = 2;
            ShowNotifications = true;
        }

        public bool RememberUser { get; set; }
        public int RefreshMinutes { get; set; }
        public int RefreshSeconds { get; set; }
        public bool ShowNotifications { get; set; }
    }
}
