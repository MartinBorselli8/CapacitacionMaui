using Microsoft.Maui;

namespace MauiApp1;

public partial class GratitudeView : ContentPage
{
	public GratitudeView()
	{
        Application.Current.MainPage?.Unfocus();
        InitializeComponent();
    }
}