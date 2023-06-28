using BrightonMine.Models;
using Microsoft.EntityFrameworkCore;

namespace BrightonMine;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		using (var dbContext = new BaseContext())
		{
            if (!File.Exists(dbContext._connectionString))
				dbContext.Database.Migrate();
		}

		MainPage = new MainPage();
	}
}
