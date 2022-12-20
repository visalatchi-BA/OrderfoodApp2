using OrderfoodApp2;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace OrderfoodApp2
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty CornerRadiusProperty =
       BindableProperty.Create("CornerRadius", typeof(int), typeof(CustomEntry), 0);
        public int EntryCornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
    }
}
