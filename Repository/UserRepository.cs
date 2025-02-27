using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Desktop.Repository
{
    public class UserRepository
    {
        public class UserData
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            // Добавьте другие свойства, которые соответствуют данным, возвращаемым вашим API
        }

        class Program
        {
            static async Task Main(string[] args)
            {
                var apiClient = new ApiClient();

                // Установите токен (например, после аутентификации)
                apiClient.SetToken("abcdef1234567890\r\n");

                // Пример получения данных
                var data = await apiClient.GetAsync<UserData>("endpoint");
                Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

                // Пример создания ресурса
                var newData = new UserData { /* заполните данные */ };
                var createdData = await apiClient.PostAsync("endpoint", newData);
                Console.WriteLine(JsonConvert.SerializeObject(createdData, Formatting.Indented));
            }
        }


        private static List<UserModel> userModels = new List<UserModel>
        {
            new UserModel
            {
                Id = Guid.NewGuid(),
                Name = "root",
                Email = "root@mail.ru",
                Password = "rootpassword75"
            }
        };

        public static bool RegisterUser(string name, string mail, string password)
        {
            if (userModels.Any(use => use.Name == name || use.Email == mail))
            {
                return false;
            }

            var newUserModel = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = mail,
                Password = password
            };

            userModels.Add(newUserModel);
            return true;
        }

        public static UserModel? AuthorizeUser(string mail, string password) =>
            userModels.FirstOrDefault(use => use.Email == mail && use.Password == password);

        public static UserModel? GetUserByName(string name) =>
            userModels.FirstOrDefault(user => user.Name == name);
    }
}
