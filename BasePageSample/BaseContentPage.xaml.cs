using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasePageSample
{
    public partial class BaseContentPage : ContentPage
    {
        public IList<View> BasePageContent => BaseContentGrid.Children;

        public BaseContentPage()
        {
            InitializeComponent();
        }
    }
}
