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

            user.Register(user);

            user.UploadPhoto(user.Photo);

            user.SendEmail(user.Email);
        }
    }
}
