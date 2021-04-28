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
	/// Логика взаимодействия для Settings.xaml
	/// </summary>
	public partial class Settings : Page
	{
		ApplicationContext db;
		public Settings()
		{
			InitializeComponent();

			DoubleAnimation btnAnimationSignIn = new DoubleAnimation();
			btnAnimationSignIn.From = 0;
			btnAnimationSignIn.To = 178;
			btnAnimationSignIn.Duration = TimeSpan.FromSeconds(0.5);
			SignInbtn.BeginAnimation(Button.WidthProperty, btnAnimationSignIn);


			DoubleAnimation btnAnimationReg = new DoubleAnimation();
			btnAnimationReg.From = 0;
			btnAnimationReg.To = 248;
			btnAnimationReg.Duration = TimeSpan.FromSeconds(0.5);
			regButton.BeginAnimation(Button.WidthProperty, btnAnimationReg);

			DoubleAnimation btnAnimationReg1 = new DoubleAnimation();
			btnAnimationReg1.From = 0;
			btnAnimationReg1.To = 200;
			btnAnimationReg1.Duration = TimeSpan.FromSeconds(0.5);
			btnLoad.BeginAnimation(Button.WidthProperty, btnAnimationReg1);


			db = new ApplicationContext();

			

		}
		private void btnLoad_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Title = "Select a picture";
			op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
			if (op.ShowDialog() == true)
			{

				imgPhoto.Source = new BitmapImage(new Uri(op.FileName));

			}

		}


		private void Button_Reg_Click(object sender, RoutedEventArgs e)
		{
			string login = textBoxLogin.Text.Trim();
			string password = passBox.Text.Trim();
			string pass2 = passBox2.Text.Trim();
			string email = textBoxEmail.Text.Trim().ToLower();
			string message = "Hello";

			if (login.Length < 5 )
			{
				textBoxLogin.ToolTip = "Имя не должно быть короче 5 символов!";
				textBoxLogin.Background = Brushes.LightPink;
			}
			
            
			else if (password.Length < 5)
			{
				passBox.ToolTip = "Пароль должен содержать не менее 5 цифр или букв!";
				passBox.Background = Brushes.LightPink;
			}
			
			else if (pass2 != password)
            {
				passBox2.ToolTip = "Пароли не совпадают";
				passBox2.Background = Brushes.LightPink;
            }
			else if (!email.Contains("@") || !email.Contains("."))
			{
				textBoxEmail.ToolTip = "Поле должно содержать @ и точку";
				textBoxEmail.Background = Brushes.LightPink;
			}
			else if(email.Length < 5)
            {
				textBoxEmail.ToolTip = "Ваш Email не может содержать менее 5 символов";
				textBoxEmail.Background = Brushes.LightPink;
			}

            else
            {
				textBoxLogin.ToolTip = "Все Верно!";
				textBoxLogin.Background = Brushes.Transparent;
				passBox.ToolTip = "Все Верно!";
				passBox.Background = Brushes.Transparent;
				passBox2.ToolTip = "Все Верно!";
				passBox2.Background = Brushes.Transparent;
				textBoxEmail.ToolTip = "Все Верно!";
				textBoxEmail.Background = Brushes.Transparent;

				User user = new User(login, email, password, message);

				db.Users.Add(user);
				db.SaveChanges();
				
				MessageBox.Show("Ваш профиль был добавлен в нашу базу!");


				NavigationService.Navigate(new SignInWindow());
			}
		}

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
			NavigationService.Navigate(new SignInWindow());
        }
    }

}

