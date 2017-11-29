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
        public MainWindow()
        {
            InitializeComponent();

            double width = mainPanel.Width / 5;
            double height = mainPanel.Height / 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mainPanel.Children.Add(new Button
                    {
                        Width = width,
                        Height = height
                    });
                }
            }
            //this.SizeChanged += MainWindow_SizeChanged;
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        //private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    this.SizeToContent = SizeToContent.WidthAndHeight;
        //}
    }
}
