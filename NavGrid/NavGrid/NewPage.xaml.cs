namespace NavGrid;

public partial class NewPage : ContentPage
{
	public NewPage()
	{
		InitializeComponent();
	}

	private void GoBackClick(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
	}
}