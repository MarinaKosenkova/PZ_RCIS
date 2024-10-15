using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Desktop
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == "введите имя пользователя")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "введите имя пользователя";
                UsernameTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTextBox.Text == "exam@yandex.ru")
            {
                EmailTextBox.Text = "";
                EmailTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "exam@yandex.ru";
                EmailTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private string password = string.Empty;
        private string confirmPassword = string.Empty;

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "введите пароль")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "введите пароль";
                PasswordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ConfirmPasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == "повторите пароль")
            {
                ConfirmPasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void ConfirmPasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                ConfirmPasswordTextBox.Text = "повторите пароль";
                ConfirmPasswordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow firstWindow = new MainWindow();
            firstWindow.Show();
            this.Close();
        }
    }
}

