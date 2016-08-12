using Foundation;
using System;
using UIKit;

namespace FoodSearch
{
    public partial class RankFoodListController : UIViewController
    {
        public RankFoodListController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//string[] data = new string[] { "Chicken noodles", "Wonton noodles", "Teriyaki fish", "Breakfast miso", "Spanish chicken", "Simply Spanish" };
			//string[] subtitle = new string[] { "Soup for the soul: Tina Li's chicken stock soup with pork meatballs and tofu.", "Vibrant prawn and wonton noodle soup: substitute the prawn for chicken if you prefer.",
			//"Delicious: Find out why teriyaki is traditionally a fish dish in Japan.", "Warm and soothing, sip after sip: Breakfast miso.",
			// "A simple braise suitable for a midweek dinner.", "Spanish style chorizo, saffron and chickpea soup."};
			//string[] foodarray = new string[] { "chinese_0.jpg", "chinese_1.jpg", "japanese_0.jpg", "japanese_1.jpg", "spanish_0.jpg", "spanish_1.jpg" };


			// Perform any additional setup after loading the view, typically from a nib.

			//UITableView _table;
			var foodManager = FoodManager.Create();

			//_table = new UITableView
			//{
			//	Frame = new CoreGraphics.CGRect(0, 30, View.Bounds.Width, View.Bounds.Height - 30),
			//	//Source = new TableSource(data, subtitle, foodarray)
			//	Source = new TableSource(foodManager.Foods, this)
			//};

			//View.AddSubview(_table);

			FoodTable2.Source = new RankFoodTableSource(foodManager.Foods, this);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals("FoodSegue2"))
			{
				var viewController = segue.DestinationViewController as FoodDetailViewController;
				if (viewController != null)
				{
					var rowPath = FoodTable2.IndexPathForSelectedRow;
					var food = (FoodManager.Create()).Foods[rowPath.Section];
					viewController.Food = food;

				}
			}
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}
    }
}