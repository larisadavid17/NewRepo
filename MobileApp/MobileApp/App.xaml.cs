using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.View;
using MobileApp.Data;
using System.IO;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileApp
{
    public partial class App : Application
    {
        static EmployeeDatabase database;
        public static EmployeeDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                    EmployeeDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "salonDb.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new XF_LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
