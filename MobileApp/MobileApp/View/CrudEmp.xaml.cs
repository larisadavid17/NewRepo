using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Models;
using MobileApp.Data;
using System.IO;

namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrudEmp : ContentPage
    {
        public CrudEmp()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetShopListsAsync();
        }
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPag
            {
                BindingContext = new Employee()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListPag
                {
                    BindingContext = e.SelectedItem as Employee
                });
            }
        }
    }
}