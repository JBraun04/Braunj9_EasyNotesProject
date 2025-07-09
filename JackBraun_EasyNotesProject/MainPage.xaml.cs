namespace JackBraun_EasyNotesProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void Btn1EditClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NoteEntry());
        }
    }
}
