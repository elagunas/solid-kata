using SolidKataConsoleApp.Step1.Data;
using SolidKataConsoleApp.Step1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidKataConsoleApp.Step1.Services
{
    public class UserService
    {
        public void Register(User user)
        {
            //register user
            UserRepository userRepository = new UserRepository();
            userRepository.Register(user);

            //upload user photo to cloud
            UploadPhoto(user.Photo);

            //send notification to email
            SendEmail(user.Email);
        }

        private void UploadPhoto(string userPhoto)
        {
            FileCloudService fileCloudService = new FileCloudService();

            fileCloudService.Upload(userPhoto);
        }

        private void SendEmail(string userEmail)
        {
            EmailService emailService = new EmailService();

            emailService.Send(userEmail);
        }
    }
}
