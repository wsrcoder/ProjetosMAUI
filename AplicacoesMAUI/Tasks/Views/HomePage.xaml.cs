namespace Tasks.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void OnAddTask(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new TaskPage());
    }
}