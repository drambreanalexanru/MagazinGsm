using MagazinGsm.Models;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace MagazinGsm;

public partial class FurnizorEntryPage : ContentPage
{
	public FurnizorEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetFurnizorAsync();
    }
    async void OnShopAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FurnizorPage
            {
            BindingContext = new Furnizor()
        });
    }
    async void OnListViewItemSelected(object sender,
   SelectedItemChangedEventArgs e)
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