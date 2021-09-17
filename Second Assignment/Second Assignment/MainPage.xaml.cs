using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Second_Assignment
{
    public partial class MainPage : ContentPage
    {
        static String[] str = { "Hey I love Coding", "It is fun", "Too much fun", "It is the best", "Hey Hey Hey", "Chirp Chirp" };
        int i = 0;
        int len = str.Length;

        public MainPage()
        {
            InitializeComponent();


        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i < len)
            {
                label.Text = str[i];
                i++;

                if (i == len)
                {
                    i = 0;
                }
            }
        }


        private void slider_DragCompleted(object sender, EventArgs e)
        {
            label.FontSize = (int)slider.Value;
        }
    }
}
