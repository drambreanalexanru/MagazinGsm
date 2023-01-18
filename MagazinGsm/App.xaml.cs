using System;
using MagazinGsm.Data;
using System.IO;
namespace MagazinGsm;

public partial class App : Application
{
    static MagazinGsmDatabase database;
    public static MagazinGsmDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               MagazinGsmDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "CosCumparaturi.db3"));
            }
            return database;
        }
    }


    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
