using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Magic_counter_helper.Resources;

namespace Magic_counter_helper
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Add(TextBlock player)
        {
            player.Text = (int.Parse(player.Text) + 1).ToString();
        }

        private void Subtract(TextBlock player)
        {
            player.Text = (int.Parse(player.Text) - 1).ToString();
        }

        private void AddEvent(object sender, RoutedEventArgs e)
        {
            if (sender == addLifeButtonPlayer1)
            {
                Add(Player1Lifes);
            }
            else if (sender == addLifeButtonPlayer2)
            {
                Add(Player2Lifes);
            }
            else if (sender == addPoisonButtonPlayer1)
            {
                Add(Player1Poison);
            }
            else
            {
                Add(Player2Poison);
            }
        }

        private void SubtractEvent(object sender, RoutedEventArgs e)
        {
            if (sender == subtractLifeButtonPlayer1)
            {
                Subtract(Player1Lifes);
            }
            else if (sender == subtractLifeButtonPlayer2)
            {
                Subtract(Player2Lifes);
            }
            else if (sender == subtractPoisonButtonPlayer1)
            {
                Subtract(Player1Poison);
            }
            else
            {
                Subtract(Player2Poison);
            }
        }


    }
}