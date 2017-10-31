using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580098A
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyPage1 : ContentPage
	{
		public MyPage1 ()
		{
			InitializeComponent ();
            nextButton.Clicked += NextButton_Clicked;
		}

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage2());   
        }
    }
}