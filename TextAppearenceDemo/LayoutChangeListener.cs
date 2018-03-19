using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.Views.ViewTreeObserver;

namespace TextAppearenceDemo
{
    public class LayoutChangeListener : Java.Lang.Object,IOnGlobalLayoutListener
    {
        GridView mGridView;
        public LayoutChangeListener(GridView gridView)
        {
            mGridView = gridView;
        }

        public void OnGlobalLayout()
        {
            
            mGridView.GetChildAt(0).SetBackgroundColor(Android.Graphics.Color.Purple);
        }
    }
}