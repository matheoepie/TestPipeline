using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestPipeline.Models;
using TestPipeline.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestPipeline.Views
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