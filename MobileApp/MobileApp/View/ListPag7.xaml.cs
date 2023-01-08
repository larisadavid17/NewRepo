using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPag7 : ContentPage
    {
        public ListPag7()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Appointment)BindingContext;
            await App.Database.SaveShopListAsync5(slist);
            await Navigation.PopAsync();
        }
    }

}