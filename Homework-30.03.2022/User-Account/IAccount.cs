using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_30._03._2022
{
    public interface IAccount
    {
        bool PasswordChecker(string pass);
        void ShowInfo();
    }
}
