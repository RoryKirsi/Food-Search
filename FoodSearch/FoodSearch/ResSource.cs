using System;
using UIKit;
using Foundation;

namespace FoodSearch
{
	public class ResSource : UITableViewSource
	{
		ResData[] ResItems;

		//string[] tableItems;
		//string[] tableSubtitle;
		//string[] tableResImage;
		string cellIdentifier = "ResCell";

		public ResSource(ResData[] ress)
		{
			//tableItems = items;
			//tableSubtitle = subtitle;
			//tableResImage = foodimage;
			ResItems = ress;

		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return ResItems.Length;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//new UIAlertView("Alert", "You touched: " + tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			ResData item = ResItems[indexPath.Row];
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
			cell.TextLabel.Text = item.ResName;
			cell.DetailTextLabel.Text = item.ResDescription;
			cell.ImageView.Image = UIImage.FromFile(item.ResImage);
			return cell;
		}
	}
}

