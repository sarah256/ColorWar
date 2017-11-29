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

namespace ColorWar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gridWidth = 5;
        int gridHeight = 5;
        //Button[,] buttonGrid = new Button[5, 5];

        public MainWindow()
        {
            InitializeComponent();

            CreateGrid(gridWidth, gridHeight);
            //this.SizeChanged += MainWindow_SizeChanged;
        }

        private void textBoxWidth_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainPanel.Children.RemoveRange(0, mainPanel.Children.Count);

            int.TryParse(textBoxWidth.Text.ToString(), out gridWidth);

            CreateGrid(gridWidth, gridHeight);
        }

        private void textBoxHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainPanel.Children.RemoveRange(0, mainPanel.Children.Count);

            int.TryParse(textBoxHeight.Text.ToString(), out gridHeight);

            CreateGrid(gridWidth, gridHeight);
        }

        private void CreateGrid(int widthValue, int heightValue)
        {
            double width = mainPanel.Width / widthValue;
            double height = mainPanel.Height / heightValue;

            for (int i = 0; i < widthValue; i++)
            {
                for (int j = 0; j < heightValue; j++)
                {
                    mainPanel.Children.Add(new Button
                    {
                        Width = width,
                        Height = height
                    });
                }
            }
        }

        //private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        //{

        //}

        //private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    this.SizeToContent = SizeToContent.WidthAndHeight;
        //}
    }
}
