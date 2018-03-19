using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GUI
{
    /// <summary>
    /// Interaction logic for slidingPuzzle.xaml
    /// </summary>
    public partial class slidingPuzzle : Window
    {
        private int _start;
        public string elapsed = String.Empty;
        public int i = 0;


        DispatcherTimer timer = new DispatcherTimer();

        /// <summary>
        /// Sliding Puzzle
        /// </summary>
        BitmapImage image;
        Image img;
        List<Rectangle> initialUnallocatedParts = new List<Rectangle>();
        List<Rectangle> allocatedParts = new List<Rectangle>();

        public slidingPuzzle()
        {
            InitializeComponent();
            
            // sliding puzzle

            timer.Interval = TimeSpan.FromMilliseconds(1000);
            _start = Environment.TickCount;
            timer.Tick += new EventHandler(timer_Tick);
            timer.IsEnabled = true;
            timer.Stop();
        }

        /// <summary>
        /// Randomize Tiles
        /// </summary>

        private void RandomizeTiles()
        {
            Random rand = new Random();
            int allocated = 0;
            while (allocated != 8)
            {
                int index = 0;
                if (initialUnallocatedParts.Count > 1)
                {
                    index = (int)(rand.NextDouble() * initialUnallocatedParts.Count);
                }
                allocatedParts.Add(initialUnallocatedParts[index]);
                initialUnallocatedParts.RemoveAt(index);
                allocated++;
            }
        }

        public void CreatePuzzleForImage()
        {
            initialUnallocatedParts.Clear();
            allocatedParts.Clear();

            //row0
            CreateImagePart(0, 0, 0.33333, 0.33333);
            CreateImagePart(0.33333, 0, 0.33333, 0.33333);
            CreateImagePart(0.66666, 0, 0.33333, 0.33333);
            //row1
            CreateImagePart(0, 0.33333, 0.33333, 0.33333);
            CreateImagePart(0.33333, 0.33333, 0.33333, 0.33333);
            CreateImagePart(0.66666, 0.33333, 0.33333, 0.33333);
            //row2
            CreateImagePart(0, 0.66666, 0.33333, 0.33333);
            CreateImagePart(0.33333, 0.66666, 0.33333, 0.33333);
            RandomizeTiles();
            CreateBlankRect();

            int index = 0;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    allocatedParts[index].SetValue(Grid.RowProperty, i);
                    allocatedParts[index].SetValue(Grid.ColumnProperty, j);
                    slidingPuzzleGrid.Children.Add(allocatedParts[index]);
                    index++;
                }
            }
        }

        /// <summary>
        /// Create blank tile
        /// </summary>
        private void CreateBlankRect()
        {
            Rectangle rectPart = new Rectangle();
            rectPart.Fill = new SolidColorBrush(Colors.Black);
            rectPart.Margin = new Thickness(0);
            rectPart.HorizontalAlignment = HorizontalAlignment.Stretch;
            rectPart.VerticalAlignment = VerticalAlignment.Stretch;
            allocatedParts.Add(rectPart);
        }

        /// <summary>
        /// Creates a ImageBrush using x/y/width/height params
        /// to create a Viewbox to only show a portion of original
        /// image. This ImageBrush is then used to fill a Rectangle
        /// which is added to the internal list of unallocated
        /// Rectangles
        /// </summary>
        private void CreateImagePart(double x, double y, double width, double height)
        {
            ImageBrush ib = new ImageBrush();
            ib.Stretch = Stretch.UniformToFill;
            ib.ImageSource = image;
            ib.Viewport = new Rect(0, 0, 1.0, 1.0);
            //grab image portion
            ib.Viewbox = new Rect(x, y, width, height);
            ib.ViewboxUnits = BrushMappingMode.RelativeToBoundingBox;
            ib.TileMode = TileMode.None;

            Rectangle rectPart = new Rectangle();
            rectPart.Fill = ib;
            rectPart.Margin = new Thickness(0);
            rectPart.HorizontalAlignment = HorizontalAlignment.Stretch;
            rectPart.VerticalAlignment = VerticalAlignment.Stretch;
            rectPart.MouseDown += new MouseButtonEventHandler(rectPart_MouseDown);
            initialUnallocatedParts.Add(rectPart);
        }

        private void rectPart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //get the source Rectangle, and the blank Rectangle
            //NOTE : Blank Rectangle never moves, its always the last Rectangle
            //in the allocatedParts List, but it gets re-allocated to 
            //different Gri Row/Column
            Rectangle rectCurrent = sender as Rectangle;
            Rectangle rectBlank = allocatedParts[allocatedParts.Count - 1];

            //get current grid row/col for clicked Rectangle and Blank one
            int currentTileRow = (int)rectCurrent.GetValue(Grid.RowProperty);
            int currentTileCol = (int)rectCurrent.GetValue(Grid.ColumnProperty);
            int currentBlankRow = (int)rectBlank.GetValue(Grid.RowProperty);
            int currentBlankCol = (int)rectBlank.GetValue(Grid.ColumnProperty);

            //create possible valid move positions
            List<PossiblePositions> posibilities = new List<PossiblePositions>();
            posibilities.Add(new PossiblePositions
            { Row = currentBlankRow - 1, Col = currentBlankCol });
            posibilities.Add(new PossiblePositions
            { Row = currentBlankRow + 1, Col = currentBlankCol });
            posibilities.Add(new PossiblePositions
            { Row = currentBlankRow, Col = currentBlankCol - 1 });
            posibilities.Add(new PossiblePositions
            { Row = currentBlankRow, Col = currentBlankCol + 1 });

            //check for valid move
            bool validMove = false;
            foreach (PossiblePositions position in posibilities)
                if (currentTileRow == position.Row && currentTileCol == position.Col)
                    validMove = true;

            //only allow valid move
            if (validMove)
            {
                rectCurrent.SetValue(Grid.RowProperty, currentBlankRow);
                rectCurrent.SetValue(Grid.ColumnProperty, currentBlankCol);

                rectBlank.SetValue(Grid.RowProperty, currentTileRow);
                rectBlank.SetValue(Grid.ColumnProperty, currentTileCol);
            }
            else
                return;
        }



     
        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            i++;
            TimeSpan result = TimeSpan.FromSeconds(i);
            string fromTimestring = result.ToString("mm' : 'ss");
            LblTime.Content = fromTimestring;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Highscore win2 = new Highscore();
            win2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoadGame win2 = new LoadGame();
            win2.Show();
            this.Close();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            NewGame win2 = new NewGame();
            win2.Show();
            this.Close();
        }


        // Stopwatch Start
        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        // Stopwatch Stop
        private void Stop_OnClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Picture_OnClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG" +
                         "|All Files (*.*)|*.*";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == true)
            {
                try
                {
                    image = new BitmapImage(new Uri(ofd.FileName, UriKind.RelativeOrAbsolute));
                    img = new Image { Source = image };
                    CreatePuzzleForImage();
                }
                catch
                {
                    MessageBox.Show("Couldnt load the image file " + ofd.FileName);
                }
            }
        }

        private void PictureTest_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                image = new BitmapImage(new Uri("/Numbers/amsterdam1.jpg", UriKind.RelativeOrAbsolute));
                img = new Image { Source = image };

                CreatePuzzleForImage();

            }
            catch
            {
                MessageBox.Show("Couldn't load the image file");
            }
           
        }
    }
       

    struct PossiblePositions
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
