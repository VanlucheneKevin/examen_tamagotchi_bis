using System;
using System.Windows;
using Pra.Tamagotchi.Core.Interfaces;
using Pra.Tamagotchi.Core.Services;
using Pra.Tamagotchi.Core.Entities;

namespace Pra.Tamagotchi.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TamagotchiCollection tamagotchiCollection;
        public MainWindow()
        {
            InitializeComponent();
            tamagotchiCollection = new TamagotchiCollection();
            UpdateListBox();

            
        }

        private void UpdateListBox()
        {
            lstTamagotchis.ItemsSource = tamagotchiCollection.Tamagotchis;
            lstTamagotchis.Items.Refresh();
        }

        private void btnGrow_Click(object sender, RoutedEventArgs e)
        {
            if(lstTamagotchis.SelectedItem != null)
            {
                foreach (ITamagotchi tamagotchi in tamagotchiCollection.Tamagotchis)
                {
                    ITamagotchi currentTamagotchi = (ITamagotchi)lstTamagotchis.SelectedItem;
                    if (tamagotchi is IHatchable)
                    {
                        currentTamagotchi.Grow();
                        UpdateListBox();
                    }
                    if (tamagotchi is IFeedable)
                    {
                        currentTamagotchi.Grow();
                        UpdateListBox();
                    }

                }

            }
        }

        private void btnAddEgg_Click(object sender, RoutedEventArgs e)
        {
            tamagotchiCollection.AddEggs();
            UpdateListBox();
        }

        private void btnHatch_Click(object sender, RoutedEventArgs e)
        {
            if (lstTamagotchis.SelectedItem != null)
            {
                IHatchable currentEgg = (IHatchable)lstTamagotchis.SelectedItem;
                if(currentEgg is Egg)
                {
                    try
                    {
                        //TamagotchiCollection.Hatch(currentEgg);
                        UpdateListBox();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
