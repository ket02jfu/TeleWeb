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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace teleWeb2
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Page
    {
        public SignInWindow()
        {
            InitializeComponent();

            DoubleAnimation btnAnimationSignIn = new DoubleAnimation();
            btnAnimationSignIn.From = 0;
            btnAnimationSignIn.To = 296;
            btnAnimationSignIn.Duration = TimeSpan.FromSeconds(0.5);
            SignInbtn.BeginAnimation(Button.WidthProperty, btnAnimationSignIn);


            DoubleAnimation btnAnimationReg = new DoubleAnimation();
            btnAnimationReg.From = 0;
            btnAnimationReg.To = 148;
            btnAnimationReg.Duration = TimeSpan.FromSeconds(0.5);
            regButton.BeginAnimation(Button.WidthProperty, btnAnimationReg);
        }


        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = passBox.Text.Trim();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле введено не корректно!";
                textBoxLogin.Background = Brushes.LightPink;
            }


            else if (password.Length < 5)
            {
                passBox.ToolTip = "Это поле введено не корректно!";
                passBox.Background = Brushes.LightPink;
            }
            else
            {
                textBoxLogin.ToolTip = "Все Верно!";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "Все Верно!";
                passBox.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
                }
                if(authUser != null)
                {
                    MessageBox.Show("Добро пожаловать!");
                    NavigationService.Navigate(new Menu());
                }
                else
                {
                    MessageBox.Show("Вы ввели что-то не то!");
                }

                
            }
        }

        private void buttonRegClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings());
        }
    }
}
