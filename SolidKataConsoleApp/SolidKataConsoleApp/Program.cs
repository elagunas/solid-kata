using SolidKataConsoleApp.Step1.Models;
using SolidKataConsoleApp.Step1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidKataConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Username = "myUserName";
            user.Password = "mySecurePassword";
            user.Email = "myemail@email.me";
            user.Photo = "base64photo";

            UserService userService = new UserService();

            userService.Register(user);
        }
    }
}
