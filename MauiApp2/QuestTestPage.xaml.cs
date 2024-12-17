using MauiApp2.Models;

namespace MauiApp2;

public partial class QuestTestPage : ContentPage
{
	private readonly LocalDBService? _dbService;
	private int _editQuestId;
    public QuestTestPage()
	{
		InitializeComponent();
		_dbService = new LocalDBService();
		Task.Run(async () => listView.ItemsSource = await _dbService.GetQuests());
	}

	private async void saveButtonClicked(object sender, EventArgs e)
	{
        if (_editQuestId == 0)
		{
			// Add Quest

			await _dbService.CreateQuest(new Quest
			{
				Content = contentEntryField.Text
			});
		}
		else
		{
            // Edit Quest

            await _dbService.CreateQuest(new Quest
            {
                Content = contentEntryField.Text
            });
        }
	}

	private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
	{

	}
}