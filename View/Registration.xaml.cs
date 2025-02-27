using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Desktop.Repository;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ApiClient
{

    private static readonly HttpClient client = new HttpClient();
    private static string token;

    // URL вашего API
    private const string BaseUrl = "http://45.144.64.179/api/";

    public ApiClient()
    {
        // Устанавливаем базовый адрес для клиента
        client.BaseAddress = new Uri(BaseUrl);
    }

    // Метод для установки токена
    public void SetToken(string newToken)
    {
        token = newToken;
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    // Пример метода для получения данных
    public async Task<T> GetAsync<T>(string endpoint)
    {
        var response = await client.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();
        var jsonResponse = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(jsonResponse);
    }

    // Пример метода для создания ресурса
    public async Task<T> PostAsync<T>(string endpoint, T data)
    {
        var json = JsonConvert.SerializeObject(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(endpoint, content);
        response.EnsureSuccessStatusCode();
        var jsonResponse = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(jsonResponse);
    }


    // Метод для обновления ресурса
    public async Task<T> PutAsync<T>(string endpoint, T data)
    {
        var json = JsonConvert.SerializeObject(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PutAsync(endpoint, content);
        response.EnsureSuccessStatusCode();
        var responseJson = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(responseJson);
    }

    // Метод для удаления ресурса
    public async Task DeleteAsync(string endpoint)
    {
        var response = await client.DeleteAsync(endpoint);
        response.EnsureSuccessStatusCode();
    }
}


namespace Desktop.View
{
    public partial class Registration : Page
    {
        public Registration()
        {
            
            InitializeComponent();

            usernameBox.Foreground = Brushes.Gray;
            mailBox.Foreground = Brushes.Gray;
            passBlock.Foreground = Brushes.Gray;
            pass2Block.Foreground = Brushes.Gray;
        }

        private void UsernameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text == "Введите имя пользователя" && usernameBox.Foreground == Brushes.Gray)
            {
                usernameBox.Text = "";
                usernameBox.Foreground = Brushes.Black;
            }
        }

        private void UsernameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text == "")
            {
                usernameBox.Foreground = Brushes.Gray;
                usernameBox.Text = "Введите имя пользователя";
            }
        }

        private void MailBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mailBox.Text == "exam@yandex.ru" && mailBox.Foreground == Brushes.Gray)
            {
                mailBox.Text = "";
                mailBox.Foreground = Brushes.Black;
            }
        }

        private void MailBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mailBox.Text == "")
            {
                mailBox.Foreground = Brushes.Gray;
                mailBox.Text = "exam@yandex.ru";
            }
        }

        private void PassPASSwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passPASSwordBox.Password == "")
                passBlock.Visibility = Visibility.Hidden;
        }

        private void PassPASSwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passPASSwordBox.Password == "")
                passBlock.Visibility = Visibility.Visible;
        }

        private void PassPASSwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passPASSwordBox.Password != "")
                passBlock.Visibility = Visibility.Hidden;
            else
                passBlock.Visibility = Visibility.Visible;
        }

        private void Pass2PASSwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pass2PASSwordBox.Password == "")
                pass2Block.Visibility = Visibility.Hidden;
        }

        private void Pass2PASSwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pass2PASSwordBox.Password == "")
                pass2Block.Visibility = Visibility.Visible;
        }

        private void Pass2PASSwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pass2PASSwordBox.Password != "")
                pass2Block.Visibility = Visibility.Hidden;
            else
                pass2Block.Visibility = Visibility.Visible;
        }

        private void NazadB_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LogIn());
        }

        private void RegistrationB_Click(object sender, RoutedEventArgs e)
        {
            InputValidator inputValidator = new();
            string mail = mailBox.Text;
            string name = usernameBox.Text;
            string password = passPASSwordBox.Password;

            inputValidator.IsValidEmail(mail);
            inputValidator.IsValidName(name);
            inputValidator.IsValidPassword(password);

            if (!inputValidator.IsValidName(name) || name == "Введите имя пользователя")
            {
                MessageBox.Show("Имя пользователя слишком короткое!\nИмя пользователя обязательно должно содержать не менее трех символов.", "Ошибка регистрации [Имя пользователя]", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!inputValidator.IsValidEmail(mail) || mailBox.Foreground == Brushes.Gray && mailBox.Text == "exam@yandex.ru")
                MessageBox.Show("Указан неверный формат Почты!\nПример правильной Почты: example@mail.ru", "Ошибка регистрации [Почта]", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (!inputValidator.IsValidPassword(password))
                MessageBox.Show("Слишком короткий Пароль!\nПароль обязательно должен содержать не менее шести символов.", "Ошибка регистрации [Пароль]", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (password != pass2PASSwordBox.Password)
                MessageBox.Show("Пароли должны совпадать!", "Ошибка регистрации [Пароль]", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (UserRepository.RegisterUser(name, mail, password))
                {
                    this.NavigationService.Navigate(new MainEmpty(name));
                }
                else
                {
                    MessageBox.Show("Пользователь с таким именем или почтой уже существует.", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
