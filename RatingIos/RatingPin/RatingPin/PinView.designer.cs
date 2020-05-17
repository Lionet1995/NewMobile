// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RatingPin
{
    [Register ("PinView")]
    partial class PinView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button5 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView pinView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Button1 != null) {
                Button1.Dispose ();
                Button1 = null;
            }

            if (Button2 != null) {
                Button2.Dispose ();
                Button2 = null;
            }

            if (Button3 != null) {
                Button3.Dispose ();
                Button3 = null;
            }

            if (Button4 != null) {
                Button4.Dispose ();
                Button4 = null;
            }

            if (Button5 != null) {
                Button5.Dispose ();
                Button5 = null;
            }

            if (pinView != null) {
                pinView.Dispose ();
                pinView = null;
            }
        }
    }
}