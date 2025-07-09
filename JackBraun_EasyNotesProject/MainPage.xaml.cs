namespace JackBraun_EasyNotesProject
{
    public partial class MainPage : ContentPage
    {
        private int count; // Field 'count' is now used.

        public MainPage()
        {
            InitializeComponent();
            count = 0; // Initialize 'count' and use it meaningfully.
        }

        private async void Btn1EditClicked(object sender, EventArgs e)
        {
            count++; // Increment 'count' to track button clicks.
            await Navigation.PushAsync(new NoteEntry());
        }

        private async void AboutButtonClicked(object sender, EventArgs e)
        {
            count++; // Increment 'count' to track button clicks.
            await Navigation.PushAsync(new AboutPage());
        }
    }
}

