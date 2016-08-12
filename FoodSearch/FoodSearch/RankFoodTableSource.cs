using System;
using UIKit;
using Foundation;

namespace FoodSearch
{
	public class RankFoodTableSource : UITableViewSource
	{
		FoodData[] FoodItems;
		RankFoodListController hostViewCOntroller;
		string cellIdentifier = "TableCell2";

		public RankFoodTableSource(FoodData[] foods, RankFoodListController hostVC)
		{
			FoodItems = foods;
			hostViewCOntroller = hostVC;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return FoodItems.Length;
		}

		public override string TitleForHeader(UITableView tableView, nint section)
		{
			return "Rank" + (section + 1);
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return 1;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//new UIAlertView("Alert", "You touched: " + tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			FoodData item = FoodItems[indexPath.Section];
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
			cell.TextLabel.Text = item.FoodName;
			cell.DetailTextLabel.Text = item.FoodDescription;
			cell.ImageView.Image = UIImage.FromFile(item.FoodImage);
			return cell;
		}
	}
}

