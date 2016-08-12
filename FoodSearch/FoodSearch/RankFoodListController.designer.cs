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
    [Register ("RankFoodListController")]
    partial class RankFoodListController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView FoodTable2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FoodTable2 != null) {
                FoodTable2.Dispose ();
                FoodTable2 = null;
            }
        }
    }
}