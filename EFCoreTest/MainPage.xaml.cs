using Microsoft.EntityFrameworkCore;

namespace EFCoreTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
			Models.bencomlicensingContext DB = new Models.bencomlicensingContext();
			DB.Database.OpenConnection();
            DB.Database.CloseConnection();
            //var lic = DB.License.ToList();
            Shell.Current.DisplayAlert("Success", "Success", "OK");
		}
		catch (Exception ex)
		{
            Shell.Current.DisplayAlert("Failed", ex.Message, "OK");
        }
	}

    private void OnCounterClicked2(object sender, EventArgs e)
    {
        try
        {
            Models.bencomlicensingContext DB = new Models.bencomlicensingContext();
            var lic = DB.License.First().SerialNo;
            Shell.Current.DisplayAlert("Success", lic, "OK");
        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Failed", ex.Message, "OK");
        }
    }
}

