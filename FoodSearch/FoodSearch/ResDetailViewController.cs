using Foundation;
using System;
using UIKit;

namespace FoodSearch
{
    public partial class ResDetailViewController : UIViewController
    {
        public ResDetailViewController (IntPtr handle) : base (handle)
        {
        }

		public ResData Res { get; set; }

		public override void ViewWillAppear(bool animated)
		{
			FoodImage.Image = UIImage.FromBundle(Res.ResEnviro);
			FoodTitle.Title = Res.ResName;
			FoodDetail.Text = Res.ResOverView;
		}
    }
}