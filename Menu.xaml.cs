using Microsoft.Win32;
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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    /// 
    
    public partial class Menu : Page
    {
        readonly ApplicationContext db;

        public Menu()
        {
            InitializeComponent();


            db = new ApplicationContext();

            List<User> users = db.Users.ToList();

            listOfMessages.ItemsSource = users;

           

            DoubleAnimation btnReg = new DoubleAnimation();
            btnReg.From = 0;
            btnReg.To = 44;
            btnReg.Duration = TimeSpan.FromSeconds(1);
            RegBtn.BeginAnimation(Button.WidthProperty, btnReg);




        }

        private void ProfileBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profile());  
        }

        private void settingsBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings());
        }

        private void Send_Message_Click(object sender, RoutedEventArgs e)
        {
            string message = TBMessage.Text.Trim();
            string login = testLogin.Text;
            string email = testEmail.Text;
            string password = testPassword.Text;

            if (TBMessage.Text == "")
            {
                MessageBox.Show("Вы не можете отправить пустое сообщение");
            }
            else
            {
                User user = new User(login, password, email, message);
              
                db.Users.Add(user);
                db.SaveChanges();
                NavigationService.Refresh();
            }
        }
        

        private void Click_Btn_Delete_Sql(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
