﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.MathDisplay
{
    public class CursorView : BoxView
    {
        public new Expression Parent => base.Parent as Expression;
        //public double Middle => 0.5;
        /*public double FontSize
        {
            set
            {
                HeightRequest = Text.MaxTextHeight * value / Text.MaxFontSize;
            }
        }*/

        public CursorView()
        {
            WidthRequest = 1;
            VerticalOptions = LayoutOptions.Center;
        }

        public string ToLatex() => "";
        public override string ToString() => "";
    }
}
