// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RatingPin
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        RatingPin.PinView pinView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (pinView != null) {
                pinView.Dispose ();
                pinView = null;
            }
        }
    }
}