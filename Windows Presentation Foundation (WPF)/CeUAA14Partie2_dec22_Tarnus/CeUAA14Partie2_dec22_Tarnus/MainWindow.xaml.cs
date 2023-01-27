using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CeUAA14Partie2_dec22_Tarnus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalJoueur = 0;
        int ancienneValeur;
        int[] positionPionJoueur = new int[2];
        string symboleJoueur = "X";
        Button[,] buttons = new Button[10, 10];
        public MainWindow()
        {
            Grid plate = new Grid();         
            InitializeComponent();
            SetUpGame(buttons, plate);

            play.Click += new RoutedEventHandler(Jouer);
        }

        public void SetUpGame(Button[,] buttons, Grid plate)
        {
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                plate.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                plate.RowDefinitions.Add(rowDef);

                Grid.SetColumn(plate, 0);
                Grid.SetRow(plate, 1);
            }

            for (int i = 0; i < buttons.GetLength(0); i++)
            {            
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();

                    if ((i + 1) % 2 == 0)
                    {
                        if ((j + 1) % 2 != 0)
                        {
                            buttons[i, j].Background = Brushes.Aqua;
                        }
                        else
                        {
                            buttons[i, j].Background = Brushes.Red;
                        }
                    }
                    else
                    {
                        if ((j + 1) % 2 == 0)
                        {
                            buttons[i, j].Background = Brushes.Aqua;
                        }
                        else
                        {
                            buttons[i, j].Background = Brushes.Red;
                        }
                    }

                    if(i % 2 == 0)
                    {
                        buttons[i, j].Content = 10 * i + j + 1;
                    }
                    else
                    {
                        buttons[i, j].Content = (10 * i) + 10 - j;
                    }
                   
                    Grid.SetColumn(buttons[i, j], j);
                    Grid.SetRow(buttons[i, j], i);
                    plate.Children.Add(buttons[i, j]);
                    
                }             
            }

            buttons[0, 0].Content = "X";
            grdMain.Children.Add(plate);
        }


        public void Jouer(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int de = rnd.Next(1, 7);

            string numeroDe = de.ToString();
            face.Text = numeroDe;

            TourJoueur(symboleJoueur, ref totalJoueur, ref positionPionJoueur, de, ref ancienneValeur);
        }
        public void TourJoueur(string symboleJoueur, ref int totalJoueur, ref int[] positionPionJoueur, int de, ref int ancienneValeur)
        {
            ancienneValeur = totalJoueur +
                1;
            totalJoueur += de;
            int reste = totalJoueur - 10 * (positionPionJoueur[0] + 1);
            buttons[positionPionJoueur[0], positionPionJoueur[1]].Content = ancienneValeur;
            buttons[positionPionJoueur[0], positionPionJoueur[1]].Foreground = Brushes.Black;

            if(reste < 0)
            {
                reste += 10;
            }
            else
            {
                positionPionJoueur[0] += 1;
            }

            if(positionPionJoueur[0] % 2 != 0)
            {
                positionPionJoueur[1] = 9 - reste;
            }
            else
            {
                positionPionJoueur[1] = reste;
            }

            if(positionPionJoueur[0] <= 9)
            {
                buttons[positionPionJoueur[0], positionPionJoueur[1]].Content = symboleJoueur;
                buttons[positionPionJoueur[0], positionPionJoueur[1]].Foreground = Brushes.Gold;
            }
            else
            { 
                buttons[9,0].Content = symboleJoueur;
                buttons[9, 0].Foreground = Brushes.Gold;
                play.IsEnabled = false;
                victoire.Text = "Vous avez gagné!";
            }
        }
    }
}