using System;

namespace UserManagerLibrary
{
    public class UserManager
    {
        public bool Add(string userId, string phone, string email)
        {
            if (userId.Length < 4)
            {
                throw new Exception("UserId должен быть больше 4 символов");
            }

            if (phone.Contains("a"))
            {
                throw new Exception("Телефон должен содержать только цифры");
            }

            if (!email.Contains("@"))
            {
                throw new Exception("Ошибка в email адресе");
            }

            // Логика сохранения данных 

            return true;

        }
    }
}