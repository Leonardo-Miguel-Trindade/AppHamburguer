namespace AppHamburguer;

public partial class AppFlyoutPage : FlyoutPage
{
	public AppFlyoutPage()
	{
		InitializeComponent();

		//Define que a página inicial aberta dentro do Detail é a MainPage (Home)
		Detail = new NavigationPage(new MainPage());
    }

	private void gasetaClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new CalculoPage());
        IsPresented = false; 

    }

	private void OnautonomiaClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new CalcularAutonomia());
        IsPresented = false;
    }
}