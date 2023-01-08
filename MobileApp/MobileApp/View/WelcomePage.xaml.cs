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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void crudcl_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudCli());
        }

        private void crudser_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new CrudService());
        }

        private void crudor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudSchedule());
        }

        private void crudemp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudEmp());
        }

        private void crudapp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudApp());

        }
    }
}