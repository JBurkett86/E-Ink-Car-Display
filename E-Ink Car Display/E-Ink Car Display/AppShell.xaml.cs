using E_Ink_Car_Display.ViewModels;
using E_Ink_Car_Display.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace E_Ink_Car_Display
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
