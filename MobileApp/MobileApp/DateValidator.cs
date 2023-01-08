using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace MobileApp
{
    class DateValidator : Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            bool IsValid = true;
            String value = args.NewTextValue;
            String day = value.Substring(0,2);
            String month = value.Substring(3,2);
            String year = value.Substring(6,4);
            String hour = value.Substring(11, 2);
            
            int day2 = Convert.ToInt32(day);
            int month2 = Convert.ToInt32(month);
            int year2 = Convert.ToInt32(year);
            int hour2 = Convert.ToInt32(hour);
            
            String currentYear = DateTime.Now.Year.ToString();
            String currentMonth = DateTime.Now.Month.ToString();
            String currentDay = DateTime.Now.Day.ToString();
            int currentYear2 = Convert.ToInt32(currentYear);
            int currentMonth2= Convert.ToInt32(currentMonth);
            int currentDay2= Convert.ToInt32(currentDay);
            if (year2 < currentYear2 | month2 < currentMonth2 | day2 < currentDay2 | hour2 < 8 | hour2 > 17)
            {
                IsValid = false;
            }
            else IsValid = false;
            ((Editor)sender).BackgroundColor = IsValid ? Color.Default : Color.Red;

        }
    }
}
