using MagazinGsm.Models;

namespace MagazinGsm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CosEntryPage : ContentPage
    {
        public CosEntryPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetCosCumparaturiAsync();
        }
        async void OnCosCumparaturiAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage { BindingContext = new CosCumparaturi() });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListPage { BindingContext = e.SelectedItem as CosCumparaturi });
            }
        }
    }
}


