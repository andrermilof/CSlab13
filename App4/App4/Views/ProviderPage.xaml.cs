using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App4.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProviderPage : ContentPage
    {
        public ProviderPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                ProviderCollecion.ItemsSource = await App.Data.ReadProviders();
            }
            catch { }
        }

        async void ToolbarItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProviderDetail());
        }

        async void SwipeItemInvokedE(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var prov = item.CommandParameter as ProviderModel;
            await Navigation.PushAsync(new ProviderDetail(prov));
        }

        async void SwipeItemInvokedD(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var prov = item.CommandParameter as ProviderModel;
            var res = await DisplayAlert("delete", $"delete {prov.Name}", "Yes", "No");

            if (res)
            {
                await App.Data.DeleteProvider(prov);
                ProviderCollecion.ItemsSource = await App.Data.ReadProviders();
            }
        }
    }
}