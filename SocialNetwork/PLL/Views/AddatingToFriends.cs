using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddingToFriends
    {
        public AddingToFriends(FriendServices friendServices)
        {
            FriendServices = friendServices;
        }

        public FriendServices FriendServices { get; }

        public void Adding()
        {
            var friendData = new FriendData();

            
            Console.WriteLine("Для добавления пользователя  ввидите email: ");
            friendData.Email = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Список друзей: {0}", friendData.Email);


            try
            {
                this.FriendServices.ValidData(friendData);
                SuccessMessage.Show("Пользователь успешно добавлен");
            }
            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }
            catch (Exception)
            {
                AlertMessage.Show("Ошибка при добавлении в список друзей");
            }
            
        }
    }
}
