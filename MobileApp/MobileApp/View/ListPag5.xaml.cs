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
    public partial class ListPag5 : ContentPage
    {
        public ListPag5()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Schedule)BindingContext;
            await App.Database.SaveShopListAsync4(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Schedule)BindingContext;
            await App.Database.DeleteShopListAsync4(slist);
            await Navigation.PopAsync();
        }
    }
}