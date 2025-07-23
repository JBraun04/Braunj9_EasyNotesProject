
namespace JackBraun_EasyNotesProject;

public partial class NoteEntry : ContentPage
{
    private readonly LocalDBService _dbService;
    private int _editNoteId;
    public NoteEntry(LocalDBService dBService)
	{
		InitializeComponent();
        _dbService = dBService;
    }
    private async void saveButton_Clicked(object sender, EventArgs e)
    {
        if (_editNoteId == 0)
        {
            await _dbService.Create(new NoteData
            {
                NoteTitle = noteName.Text,
                NoteContent = noteContent.Text
            });

        }
        else
        {
            await _dbService.Update(new NoteData
            {
                Id = _editNoteId,
                NoteTitle = noteName.Text,
                NoteContent = noteContent.Text

            });
            _editNoteId = 0;
        }
        noteName.Text = "";
        noteContent.Text = "";
        await Navigation.PushAsync(new MainPage(_dbService));
    }

}