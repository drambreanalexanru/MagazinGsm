using MagazinGsm;
using MagazinGsm.Models;

namespace MagazinGsm;

public partial class FurnizorPage : ContentPage
{
    public FurnizorPage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var clist = (Furnizor)BindingContext;
        await App.Database.SaveFurnizorAsync(clist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var clist = (Furnizor)BindingContext;
        await App.Database.DeleteFurnizorAsync(clist);
        await Navigation.PopAsync();

    }
}
