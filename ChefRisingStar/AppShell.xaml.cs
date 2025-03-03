﻿using ChefRisingStar.Views;
using System;
using Xamarin.Forms;

namespace ChefRisingStar
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AchievementDetailPage), typeof(AchievementDetailPage));
            Routing.RegisterRoute(nameof(GlobalFootPrintPage), typeof(GlobalFootPrintPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
