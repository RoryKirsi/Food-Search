using System;
using UIKit;
using Foundation;

namespace FoodSearch
{
	public class TableSource : UITableViewSource
	{
		FoodData[] FoodItems;
		FoodListController hostViewCOntroller;
		//string[] tableItems;
		//string[] tableSubtitle;
		//string[] tableFoodImage;
		string cellIdentifier = "TableCell";

		public TableSource(FoodData[] foods, FoodListController hostVC)
		{
			//tableItems = items;
			//tableSubtitle = subtitle;
			//tableFoodImage = foodimage;
			FoodItems = foods;
			hostViewCOntroller = hostVC;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return FoodItems.Length;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//new UIAlertView("Alert", "You touched: " + tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			FoodData item = FoodItems[indexPath.Row];
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
			cell.TextLabel.Text = item.FoodName;
			cell.DetailTextLabel.Text = item.FoodDescription;
			cell.ImageView.Image = UIImage.FromFile(item.FoodImage);
			return cell;
		}
	}
}

