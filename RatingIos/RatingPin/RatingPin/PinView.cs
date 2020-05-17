using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;
using System.ComponentModel;

namespace RatingPin
{ 
[DesignTimeVisible(true)]

    public partial class PinView : UIView, IComponent
    {
        public UIButton[] pinButtons;
        public int rating;
        [Browsable(true), Export(nameof(RatingPin1))]

        public int RatingPin1
        {
            get { return rating; }

            set
                { 
                if (value < 0 || value >= 5) return;
                GetRating(pinButtons[value]);
                rating = value;
            }
        }

        public PinView (IntPtr handle) : base (handle)
        {
           
        }

        public PinView()
        {
            
            Initialize();

        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            Initialize();

        }

        private void Initialize()
        {
            if (Site != null && Site.DesignMode)
            {
                return;
            }

            NSBundle.MainBundle.LoadNib("PinView", this, null);
            
            Frame = Bounds;
            pinView.Frame = Bounds;
            AddSubview(pinView);
          

            pinButtons = new UIButton[]
          {
                Button1, Button2, Button3, Button4, Button5
          };

            foreach (UIButton button in pinButtons)
            {
                button.SetImage(UIImage.FromBundle("appleShit_empty"), UIControlState.Normal);
                button.SetImage(UIImage.FromBundle("androidTop_fill"), UIControlState.Selected);
                
                button.TouchUpInside += (sender, args) =>
                {
                   // SetActive(sender as UIButton);
                   GetRating(sender as UIButton);
                };


            }
        }

        public void SetActive(UIButton button)
        {
            button.Selected = true;
            button.SetImage(UIImage.FromBundle("androidTop_fill"), UIControlState.Selected);

        }

        public void SetInactive(UIButton button)
        {
            button.Selected = false;
         
        }
        public void SetHighlighted(UIButton button)
        {
            button.Selected = true;
            button.SetImage(UIImage.FromBundle("windows_highlighted"), UIControlState.Selected);
        }

        public void GetRating(UIButton button)
        {
            for (int i = 0; i < 5; i++)
            {
                if (pinButtons[i].Equals(button))
                {
                    rating = i;
                    for (int j = 0; j < 5; j++)
                    {
                        if(rating == 4)
                        {
                            SetHighlighted(pinButtons[j]);
                           
                        }
                        else if (j <= rating)
                        {
                            SetActive(pinButtons[j]);
                           
                        }
                        else
                        {
                            SetInactive(pinButtons[j]);
                          
                        }
                    }
                }
                else
                    continue;
               
            }
            
        }

       
    }
}
