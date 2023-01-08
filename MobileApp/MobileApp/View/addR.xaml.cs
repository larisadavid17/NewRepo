using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp;
namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addR : ContentPage
    {
        INotificationManager notificationManager;
        int notificationNumber = 0;

        public addR()
        {
            InitializeComponent();

            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };
        }

        void OnSendClick(object sender, EventArgs e)
        {
            notificationNumber++;
            string title = $"Check appointments!";
            string message = $"Do you have a nice day? Check if you have to go to the salon. Maybe you want an appointment?";
            notificationManager.SendNotification(title, message);
        }

        void OnScheduleClick(object sender, EventArgs e)
        {
            notificationNumber++;
            string title = $"Check appointments!";
            string message = $"Do you have a nice day? Check if you have to go to the salon. Maybe you want an appointment?";
            notificationManager.SendNotification(title, message, DateTime.Now.AddHours(8));
        }

        void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var msg = new Label()
                {
                    Text = $"Notification Received:\nTitle: {title}\nMessage: {message}"
                };
                stackLayout.Children.Add(msg);
            });
        }
    }
}