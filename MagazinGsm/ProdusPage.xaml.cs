using MagazinGsm.Models;

namespace MagazinGsm;

public partial class ProdusPage : ContentPage
{
    CosCumparaturi sl;

    public ProdusPage(CosCumparaturi slist)
	{
		InitializeComponent();
        sl = slist;
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var produs = (Produs)BindingContext;
        await App.Database.SaveProdusAsync(produs);
        listView.ItemsSource = await App.Database.GetProdusAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var produs = (Produs)BindingContext;
        await App.Database.DeleteProdusAsync(produs);
        listView.ItemsSource = await App.Database.GetProdusAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetProdusAsync();
    }
    async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Produs p;
        if (listView.SelectedItem != null)
        {
            p = listView.SelectedItem as Produs;
            var lp = new ListProdus()
            {
                CosCumparaturiID = sl.ID,
                ProdusID = p.ID
            };
            await App.Database.SaveListProdusAsync(lp);
            p.ListProduse = new List<ListProdus> { lp };
            await Navigation.PopAsync();
        }

    }
    }