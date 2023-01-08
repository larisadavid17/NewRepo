using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Models;
namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPag6 : ContentPage
    {
        public ListPag6()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Appointment)BindingContext;
            await App.Database.SaveShopListAsync5(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Appointment)BindingContext;
            await App.Database.DeleteShopListAsync5(slist);
            await Navigation.PopAsync();
        }
    }
}