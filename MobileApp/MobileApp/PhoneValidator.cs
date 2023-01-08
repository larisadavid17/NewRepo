using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MobileApp
{
    class PhoneValidator:Behavior<Editor>
    {
        const string emailRegex = "^(07)[0-9]{8}$";


        protected override void OnAttachedTo(Editor bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool IsValid = false;
            IsValid = (Regex.IsMatch(e.NewTextValue, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            ((Editor)sender).BackgroundColor = IsValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Editor bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}
