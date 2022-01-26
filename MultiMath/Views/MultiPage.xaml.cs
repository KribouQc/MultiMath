using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MultiMath.Views
{
    public partial class MultiPage : ContentPage
    {
        public const int  MIN_APP = 1;
        public const int MAX_APP = 12;
        public int num1;
        public int num2;
        public int resultat;
        public MultiPage()
        {
            InitializeComponent();
            InitialiserJeu();
        }

        void Valider_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (resultat == int.Parse(ResultatEntry.Text))
                {
                    InitialiserJeu();
                }
                else
                {
                    ResultatEntry.BackgroundColor = Color.Red ;
                    ResultatEntry.TextColor = Color.White;
                    ResultatEntry.Text = "";
                }
            }
            catch
            {

            }

        }

        private void InitialiserJeu()
        {
            num1 = new Random().Next(MIN_APP, MAX_APP);
            num2 = new Random().Next(MIN_APP, MAX_APP);

            number1.Text = num1.ToString();
            number2.Text = num2.ToString();
            resultat = num1 * num2;

            ResultatEntry.BackgroundColor = Color.White;
            ResultatEntry.TextColor = Color.Black;
            ResultatEntry.Text = "";
        }
    }
}
