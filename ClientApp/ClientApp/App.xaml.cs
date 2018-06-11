using ClientApp.Data;
using ClientApp.Services;
using ClientApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientApp.Data;
using ClientApp.Services;
using Xamarin.Forms;

namespace ClientApp
{
	public partial class App : Application
	{
        private static ClientDataBase database;

        public static ClientDataBase Database
        {
            get
            {
                if(database == null)
                {
                    database = new ClientDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3"));
                }
                return database;
            }
        }
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
