using System;
using System.Collections.Generic;
using TianSmth.ViewModels;
using TianSmth.Views;
using Xamarin.Forms;

namespace TianSmth
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
