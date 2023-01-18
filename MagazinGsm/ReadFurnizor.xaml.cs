using MagazinGsm.Models;

namespace MagazinGsm;

public partial class ReadFurnizor : ContentPage
{
	public ReadFurnizor()
	{
		InitializeComponent();
	}
    async void OnFurnizorAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FurnizorPage

        {
            BindingContext = new Furnizor()
        });
    }
    async void OnFurnizorAddedView(object sender, EventArgs e)
    {
        listView.ItemsSource = await App.Database.GetFurnizorAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetFurnizorAsync();
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new FurnizorPage
            {
                BindingContext = e.SelectedItem as Furnizor
            });
        }
    }
}
