using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace teleWeb2
{
    /// <summary>
    /// Логика взаимодействия для All.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();

            DoubleAnimation btnAnimationReg = new DoubleAnimation();
            btnAnimationReg.From = 0;
            btnAnimationReg.To = 178;
            btnAnimationReg.Duration = TimeSpan.FromSeconds(1);
            btnLoad.BeginAnimation(Button.WidthProperty, btnAnimationReg);

            ApplicationContext db = new ApplicationContext();
            List<User> users = db.Users.ToList();

           /* listOfUsers.ItemsSource = users;*/

        }

        private void MenuBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        private void settingsBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings());
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
                
            }

        }
    }
}
