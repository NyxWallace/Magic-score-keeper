using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;

namespace Magic_the_gathering
{
    public sealed partial class Counter : Magic_the_gathering.Common.LayoutAwarePage
    {
        public Counter()
        {
            this.InitializeComponent();
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        //private void pageRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    if (ApplicationView.Value == ApplicationViewState.Snapped)
        //    {
        //        NormalGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        //        SnappedGrid.Visibility = Windows.UI.Xaml.Visibility.Visible;
        //    }
        //    else
        //    {
        //        NormalGrid.Visibility = Windows.UI.Xaml.Visibility.Visible;
        //        SnappedGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        //    }
        //}
    }
}
