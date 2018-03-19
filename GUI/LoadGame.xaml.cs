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
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for LoadGame.xaml
    /// </summary>
    public partial class LoadGame : Window
    {
        BitmapImage image;
        Image img;

        public LoadGame()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            slidingPuzzle win2 = new slidingPuzzle();
            win2.Show();
            this.Close();
        }

        private void Game1_Click(object sender, RoutedEventArgs e)
        {

            slidingPuzzle win2 = new slidingPuzzle();
            win2.Show();
            this.Close();

            slidingPuzzle sp = new slidingPuzzle();
            image = new BitmapImage(new Uri("/Numbers/amsterdam1.jpg", UriKind.Relative));
            img = new Image { Source = image };
            
            sp.CreatePuzzleForImage();

            
        }

    }
}
