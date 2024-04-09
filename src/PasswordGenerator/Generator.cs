using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Generator
    {
        public static string GeneratePassword(int length)
        {
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string symbols = "!@#$&?$%&*-+";

            string all = lowerCase + upperCase + numbers + symbols;

            Random random = new Random();
            string password = "";

            for(int i = 0; i < length; i++)
            {
                int numero = random.Next(all.Count());

                password += all[numero];
            }

            return password;
        }
    }
}
