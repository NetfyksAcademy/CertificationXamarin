﻿using System;

using UIKit;

namespace Fireworks
{
    public partial class ViewController : UIViewController
    {
        SimpleParticleGen fireworks;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            fireworks = new SimpleParticleGen(UIImage.FromFile("xamlogo.png"), this.View);

            buttonStart.TouchUpInside += delegate (object sender, EventArgs e)
            {
                fireworks.Start();
            };

        }

        partial void SwitchNight_ValueChanged(UISwitch sender)
        {
            if (switchNight.On)
                this.View.BackgroundColor = UIColor.FromRGB(25, 25, 112);
            else
                this.View.BackgroundColor = UIColor.White;
        }

        partial void SliderSize_ValueChanged(UISlider sender)
        {
            fireworks.ScaleMax = (nfloat)sliderSize.Value;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


    }
}
