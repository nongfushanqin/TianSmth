using System;
using System.Collections.Generic;
using System.ComponentModel;
using TianSmth.Models;
using TianSmth.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TianSmth.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}