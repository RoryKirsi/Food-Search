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
    [Register ("FavFoodListViewController")]
    partial class FavFoodListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        FoodSearch.FoodTableView FoodTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FoodTableView != null) {
                FoodTableView.Dispose ();
                FoodTableView = null;
            }
        }
    }
}