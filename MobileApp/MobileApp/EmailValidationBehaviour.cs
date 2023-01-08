using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MobileApp
{
    public class EmailValidationBehaviour : Behavior<Editor>
    {
        const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";


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