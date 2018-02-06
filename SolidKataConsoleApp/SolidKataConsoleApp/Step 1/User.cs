using System;
using System.Collections.Generic;
using System.Text;

namespace SolidKataConsoleApp
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }

        public void Register(User user)
        {
            //register user in database
        }

        public void UploadPhoto(string userPhoto)
        {
            //upload photo to cloud
        }

        public void SendEmail(string userEmail)
        {
            //send notification to user
        }
    }
}
