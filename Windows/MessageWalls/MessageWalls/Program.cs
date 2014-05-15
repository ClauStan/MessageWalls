using MessageWalls.Model;
using MessageWalls.Presenter;
using MessageWalls.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MessageWalls
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IParentView parentView = new ParentView();           
            ILoginUserView loginUserView = new LoginUserView();
            ICreateUserView createUserView = new CreateUserView();
            IWallView wallView = new WallView();
            ISettingsView settingView = new SettingsView();
            IAboutView aboutView = new AboutView();
            
            IDataModel dataModel = new DataModel();

            IParentPresenter parentPresenter = new ParentPresenter(dataModel, parentView, loginUserView, createUserView, wallView, settingView, aboutView);

            Application.Run((Form)parentView);
        }
    }
}
