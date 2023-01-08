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
    public partial class XF_LoginPage : ContentPage
    {
        public XF_LoginPage()
        {
            InitializeComponent();
        }
        private void Loginbtn_Clicked(object sender, EventArgs e)
        {
            //null or empty field validation, check weather email and password is null or empty  
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
                DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Username.Text == "admin" && Password.Text == "admin123")
                {
                    DisplayAlert("Login Success", "", "Ok");
                    //Navigate to Wellcom page after successfully login  
                    Navigation.PushAsync(new WelcomePage());
                }
                else if (Username.Text == "client" && Password.Text == "client")
                {
                    DisplayAlert("Login Success", "", "Ok");
                    //Navigate to Wellcom page after successfully login  
                    Navigation.PushAsync(new WelcomePage2());
                }
                else
                DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }
    }
}