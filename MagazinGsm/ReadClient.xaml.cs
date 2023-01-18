using MagazinGsm.Models;

namespace MagazinGsm;

public partial class ReadClient : ContentPage
{
    public ReadClient()
    {
        InitializeComponent();
    }
    async void OnClientAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListClient
        {
            BindingContext = new Client()
        });
    }
    async void OnClientAddedView(object sender, EventArgs e)
    {
        listView.ItemsSource = await App.Database.GetClientAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetClientAsync();
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListClient
            {
                BindingContext = e.SelectedItem as Client
            });
        }
    }
}
