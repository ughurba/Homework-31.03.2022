using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_30._03._2022
{
    public class User : IAccount
    {
        private static int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }






        public User(string fullName, string email, string password)
        {

            FullName = fullName;
            Email = email;


            if (PasswordChecker(password) == true)
            {
                Password = password;
                 Id++;
                
            }



        }
        public bool PasswordChecker(string pass)
        {
            bool num = false;
            bool num2 = false;
            bool num3 = false;
            if (pass.Length >= 8) // uzunluqun yoxlayir 
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i])) //boyuk herifi yoxlayir
                    {
                        num = true;
                    }
                    else if (char.IsLower(pass[i])) // kicik herifi yoxlayir 
                    {
                        num2 = true;
                    }
                    else if (char.IsNumber(pass[i])) // reqem yoxlayir
                    {
                        num3 = true;
                    }
                }
            }


            if (num == true && num2 == true && num3 == true)
            {

                return true;
            }
            else
            {
                Console.WriteLine("Account set olunmadi");
                Console.WriteLine();
                Console.WriteLine("Wifrede minimum 8 character olmalidir ve Wifrede en az 1 boyuk herif\nkicik herif ve reqem olmalidir");
            }

            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nUser Id:{Id}\nFullName:{FullName}\nEmail:{Email}\nPassword:{Password}\n");
        }

    }
}
