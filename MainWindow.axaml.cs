using Avalonia.Controls;
using Avalonia.Media.Imaging;
using System;

namespace Kadai02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



             leftImage.Source = new Bitmap("Assets/foxaL.gif");
             leftImage.IsVisible = true;

            rightImage.Source = new Bitmap("Assets/FoxaR.gif");
            rightImage.IsVisible = true;
        }




        private void OmikujiButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var random = new Random();
            int rnd = random.Next(100); // 0〜99

            string resultImg;

            if (rnd >= 90)
                resultImg = "Assets/dai.gif";
            else if (rnd >= 70)
                resultImg = "Assets/sue.gif";
            else if (rnd >= 20)
                resultImg = "Assets/kichi.gif";
            else
                resultImg = "Assets/kyo.gif";

            ResultImage.Source = new Bitmap(resultImg);
            ResultImage.IsVisible = true;
        }
    }
}
