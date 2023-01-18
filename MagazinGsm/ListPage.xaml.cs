using MagazinGsm;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using MagazinGsm.Models;

namespace MagazinGsm;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (CosCumparaturi)BindingContext;
        slist.Data = DateTime.UtcNow;
        await App.Database.SaveCosCumparaturiAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (CosCumparaturi)BindingContext;
        await App.Database.DeleteCosCumparaturiAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProdusPage((CosCumparaturi)
       this.BindingContext)
        {
            BindingContext = new Produs()
        });


    }

}