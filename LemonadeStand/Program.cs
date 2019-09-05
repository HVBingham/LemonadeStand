using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface User = new UserInterface();
            User.UserName();
            User.StandName();
            User.NeedToGOToStore();
        }
    }
}
