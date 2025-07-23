namespace JackBraun_EasyNotesProject
{
    public partial class MainPage : ContentPage
    {
        private int count; // Field 'count' is now used.
        private readonly LocalDBService _dbService;
        private int _editNoteId;
        

        public MainPage(LocalDBService dBService)
        {
            InitializeComponent();
            _dbService = dBService;
            Task.Run(async () => Lv.ItemsSource = await _dbService.GetNoteData());
            count = 0; // Initialize 'count' and use it meaningfully.
            


        }

        private async void NewButtonClicked(object sender, EventArgs e)
        {
            count++; // Increment 'count' to track button clicks.
            await Navigation.PushAsync(new NoteEntry(_dbService));
        }

        private async void AboutButtonClicked(object sender, EventArgs e)
        {
            count++; // Increment 'count' to track button clicks.
            await Navigation.PushAsync(new AboutPage());
        }
        private async void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var noteData = e.Item as NoteData;
            var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");
            switch (action)
            {
                case "Edit":
                    await Navigation.PushAsync(new NoteEntry(_dbService));
                    break;
                case "Delete":
                    await _dbService.Delete(noteData);
                    Lv.ItemsSource = await _dbService.GetNoteData();
                    break;
            }

        }
    }
}

