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
    public partial class ListPag : ContentPage
    {
        public ListPag()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Employee)BindingContext;
            await App.Database.SaveShopListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Employee)BindingContext;
            await App.Database.DeleteShopListAsync(slist);
            await Navigation.PopAsync();
        }
    }
}