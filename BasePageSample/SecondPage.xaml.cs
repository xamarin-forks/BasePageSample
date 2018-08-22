using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasePageSample
{
    public partial class SecondPage : BaseContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
