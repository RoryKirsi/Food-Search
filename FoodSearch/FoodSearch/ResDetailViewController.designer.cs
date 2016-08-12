// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FoodSearch
{
    [Register ("ResDetailViewController")]
    partial class ResDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView FoodDetail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView FoodImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem FoodTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FoodDetail != null) {
                FoodDetail.Dispose ();
                FoodDetail = null;
            }

            if (FoodImage != null) {
                FoodImage.Dispose ();
                FoodImage = null;
            }

            if (FoodTitle != null) {
                FoodTitle.Dispose ();
                FoodTitle = null;
            }
        }
    }
}