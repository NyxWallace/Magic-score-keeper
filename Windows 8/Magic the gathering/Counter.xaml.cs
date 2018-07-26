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

        private void Add(TextBlock player, TextBlock playersnapped)
        {
            player.Text = (int.Parse(player.Text) + 1).ToString();
            playersnapped.Text = (int.Parse(playersnapped.Text) + 1).ToString();
        }

        private void Subtract(TextBlock player, TextBlock playersnapped)
        {
            player.Text = (int.Parse(player.Text) - 1).ToString();
            playersnapped.Text = (int.Parse(playersnapped.Text) - 1).ToString();
        }

        private void AddEvent(object sender, RoutedEventArgs e)
        {
            if (sender == addLifeButtonPlayer1 | sender == addLifeButtonPlayer1Snapped)
            {
                Add(Player1Lifes, Player1LifesSnapped);
            }
            else if (sender == addLifeButtonPlayer2 | sender == addLifeButtonPlayer2Snapped)
            {
                Add(Player2Lifes, Player2LifesSnapped);
            }
            else if (sender == addPoisonButtonPlayer1 | sender == addPoisonButtonPlayer1Snapped)
            {
                Add(Player1Poison, Player1PoisonSnapped);
            }
            else
            {
                Add(Player2Poison, Player2PoisonSnapped);
            }
        }

        private void SubtractEvent(object sender, RoutedEventArgs e)
        {
            if (sender == subtractLifeButtonPlayer1 | sender == subtractLifeButtonPlayer1Snapped)
            {
                Subtract(Player1Lifes, Player1LifesSnapped);
            }
            else if (sender == subtractLifeButtonPlayer2 | sender == subtractLifeButtonPlayer2Snapped)
            {
                Subtract(Player2Lifes, Player2LifesSnapped);
            }
            else if (sender == subtractPoisonButtonPlayer1 | sender == subtractPoisonButtonPlayer1Snapped)
            {
                Subtract(Player1Poison, Player1PoisonSnapped);
            }
            else
            {
                Subtract(Player2Poison, Player2PoisonSnapped);
            }
        }

        private void pageRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ApplicationView.Value == ApplicationViewState.Snapped)
            {
                NormalGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SnappedGrid.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                NormalGrid.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SnappedGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            editButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            doneButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Player1Name.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Player1NameEditable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Player2Name.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Player2NameEditable.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void done(object sender, RoutedEventArgs e)
        {
            editButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            doneButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Player1Name.Text = Player1NameEditable.Text;
            Player2Name.Text = Player2NameEditable.Text;
            Player1NameSnapped.Text = Player1NameEditable.Text;
            Player2NameSnapped.Text = Player2NameEditable.Text;
            Player1Name.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Player1NameEditable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Player2Name.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Player2NameEditable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }
    }
}
