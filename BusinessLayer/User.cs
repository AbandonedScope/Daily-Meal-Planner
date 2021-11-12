using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum ActivityType
    {
        Low,
        Normal,
        Averrage,
        High
    }

    public class User : Regularable
    {
        public int Weight { set; get; }
        public int Height { set; get; }

        public int Age {set; get; }

        public ActivityType Activety { set; get;}

        public User()
        {
            Validate += (Regularable reg, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (reg is User user && (user.Age < 10 || user.Age > 150))
                    {
                        message = "The user must be at least 10 and not older than 150 years old.";
                        flag = false;
                    }
                }
            };

            Validate += (Regularable reg, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (reg is User user && (user.Height < 140 || user.Height > 250))
                    {
                        message = "The user's height must be no less than 140 and no more than 250 centimeters.";
                        flag = false;
                    }
                }
            };

            Validate += (Regularable reg, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (reg is User user && (user.Weight < 30 || user.Weight > 300))
                    {
                        message = "The user's weight must be at least 30 and not more than 300 kilograms.";
                        flag = false;
                    }
                }
            };
            
        }
    }
}
