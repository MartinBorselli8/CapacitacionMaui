namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		var navPage = new NavigationPage(new MainPage());
		navPage.BarBackground = Colors.Chocolate;
		navPage.BarTextColor = Colors.White;
		//Pila de paginas
		//MainPage = navPage;

		//FLYOUT
		//MainPage = new FlyoutPageDemo();
		
		MainPage = new TabbedPageDemo();
	}
}
