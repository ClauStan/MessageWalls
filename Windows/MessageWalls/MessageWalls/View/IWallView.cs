using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.View
{
    interface IWallView : IChildView
    {
        string NewMessageText { get; set; }
        string NewWallNameText { get; set; }
        string SelectedWall { get; set; }
        string ErrorText { get; set; }

        bool RefreshEnabled { get; set; }
        bool AddNewWallEnabled { get; set; }
        bool AddNewMessageEnabled { get; set; }

        int AutoRefreshInterval { get; set; }
        bool AutoRefreshWorking { set; get; }

        void AddNewWallName(string name);
        void SelectWallByPos(int pos);
        void AddMessageToSelectedWall(string content, string author, string date);
        void ResetMessages();
        void SetNewMessageFocus();

        event EventHandler NewWallClicked;
        event EventHandler NewMessageClicked;        
        event EventHandler RefreshWallsClicked;
        event EventHandler NewWallSelected;
        event EventHandler WallsAutoRefresh;
    }
}
