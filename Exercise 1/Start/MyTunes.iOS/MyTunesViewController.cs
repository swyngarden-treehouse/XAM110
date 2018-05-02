using UIKit;
using System.Linq;
using System.Threading.Tasks;

namespace MyTunes
{
	public class MyTunesViewController : UITableViewController
	{
		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			TableView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);
		}

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

            var data = await SongLoader.Load();
            TableView.Source = new ViewControllerSource<Song>(TableView)
            {
                DataSource = data.ToList(),
                TextProc = (s) => s.Name,
                DetailTextProc = s => $"{s.Artist} - {s.Album}"
            };
		}
	}

}

