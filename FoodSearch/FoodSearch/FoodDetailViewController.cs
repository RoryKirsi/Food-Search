using Foundation;
using System;
using UIKit;

namespace FoodSearch
{
    public partial class FoodDetailViewController : UIViewController
    {
        public FoodDetailViewController (IntPtr handle) : base (handle)
        {
        }

		public FoodData Food { get; set;}

		public override void ViewWillAppear(bool animated)
		{
			FoodImage.Image = UIImage.FromBundle(Food.FoodImage);
			FoodTitle.Title = Food.FoodName;
			FoodDetail.Text = Food.FoodRecipe;
		}
    }
}