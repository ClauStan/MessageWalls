using MessageWalls.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Model
{
    interface IDataModel
    {
        MySettings Settings { get; set; }
        User User { get; set; }

        void MergeUserModel(User user);
        Wall MergeAndReturnWallChanges(User user, string returnWallName);

        Wall GetWallByName(string name);
        Wall GetWallByPos(int pos);
        List<string> GetAllWallNames();

        
        void LoadDataModel();
        void SaveDataModel();
    }
}
