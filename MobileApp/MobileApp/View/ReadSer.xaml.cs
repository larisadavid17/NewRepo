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
    public partial class ReadSer : ContentPage
    {
        public ReadSer()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetShopListsAsync3();
        }
    }
}