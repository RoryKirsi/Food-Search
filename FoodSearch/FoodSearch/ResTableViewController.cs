using Foundation;
using System;
using UIKit;

namespace FoodSearch
{
    public partial class ResTableViewController : UITableViewController
    {
        public ResTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var resManager = ResManager.Create();
			ResTable.Source = new ResSource(resManager.Ress);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals("ResSegue"))
			{
				var viewController = segue.DestinationViewController as ResDetailViewController;
				if (viewController != null)
				{
					var rowPath = ResTable.IndexPathForSelectedRow;
					var res = (ResManager.Create()).Ress[rowPath.Row];
					viewController.Res = res;
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