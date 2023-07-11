using CommunityToolkit.Maui.Core.Platform;

namespace MauiApp1;

public partial class RegisterView : ContentPage
{
	public RegisterView()
	{
		InitializeComponent();

        lastEntry.Focused += OnLastEntryFocused;
    }
    private void OnLastEntryFocused(object sender, FocusEventArgs e)
    {
        // Calcular el desplazamiento para mover la vista hacia arriba
        double scrollY = lastEntry.Y + lastEntry.Height;

        // Desplazar la vista hacia arriba dentro del ScrollView
        scrollView.ScrollToAsync(0, scrollY, true);
    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void ButtonCancel_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void ButtonSummit_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GratitudeView());
        DisplayAlert("REGISTRADO!", "Fuiste registrado correctamente", "Ok");
    }
}