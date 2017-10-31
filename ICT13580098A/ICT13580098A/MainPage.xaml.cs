using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ICT13580098A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            genderPicker.Items.Add("Male");
            genderPicker.Items.Add("Female");
            genderPicker.Items.Add("Other");

            okButton.Clicked += OkButton_Clicked;
            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
        }


        private void OkButton_Clicked(object sender, EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }
        private void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
        private void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
