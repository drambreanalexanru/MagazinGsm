using System;
namespace MagazinGsm;


public partial class Principala : ContentPage
{


	public Principala()
	{
		InitializeComponent();
	}
	private void viewFurnizor(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ReadFurnizor());
	}
    private void viewClient(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ReadClient());
    }

}