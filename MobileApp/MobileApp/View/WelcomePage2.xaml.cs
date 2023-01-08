using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage2 : ContentPage
    {
        public WelcomePage2()
        {
            InitializeComponent();
        }
        private void viewEmp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadEmp());
        }
        private void addCl(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addCli());
        }
        private void addAp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addApp());
        }
        private void viewSer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadSer());
        }
        private void addRem(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addR());
        }
    }
}