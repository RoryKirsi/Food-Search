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
    [Register ("ResTableViewController")]
    partial class ResTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ResTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ResTable != null) {
                ResTable.Dispose ();
                ResTable = null;
            }
        }
    }
}