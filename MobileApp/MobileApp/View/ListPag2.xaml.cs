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
    public partial class ListPag2 : ContentPage
    {
        public ListPag2()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Client)BindingContext;
            await App.Database.SaveShopListAsync2(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Client)BindingContext;
            await App.Database.DeleteShopListAsync2(slist);
            await Navigation.PopAsync();
        }
    }
}