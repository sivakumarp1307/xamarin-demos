#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SampleBrowser.SfChart
{
    public partial class SplineRangeAreaChart : SampleView
    {
        public SplineRangeAreaChart()
        {
            InitializeComponent();
			if (Device.RuntimePlatform == Device.UWP)
            {
                secondaryAxisLabelStyle.LabelFormat = "'$'0";
            }
            else
            {
                secondaryAxisLabelStyle.LabelFormat = "'$'#";
            }

            if (Device.RuntimePlatform == Device.macOS || Device.RuntimePlatform == Device.UWP)
            {
                Chart.Legend.OverflowMode = ChartLegendOverflowMode.Scroll;
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if ((Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS))
            {
                if (height > 0 && width > 0)
                {
                    if (height > width)
                    {
                        Chart.PrimaryAxis.LabelStyle.Margin = new Thickness(0, 10, 0, 0);
                        Chart.Legend.DockPosition = LegendPlacement.Bottom;
                    }
                    else
                    {
                        Chart.PrimaryAxis.LabelStyle.Margin = new Thickness(0);
                        Chart.Legend.DockPosition = LegendPlacement.Right;
                    }
                }
            }
        }
    }
}