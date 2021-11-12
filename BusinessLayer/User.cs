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

    public class User
    {
        private int m_weight;
        private int m_height;
        private int m_age;

        public int Weight
        {
            set
            {
                if(value < 30 || value > 300)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Weight)} must be between 30 and 300.", nameof(Weight));
                }

                m_weight = value;
            }

            get
            {
                return m_weight;
            }
        }

        public int Height
        {
            set
            {
                if (value < 140 || value > 300)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Height)} must be between 140 and 300.", nameof(Height));
                }

                m_height = value;
            }

            get
            {
                return m_height;
            }
        }

        public int Age
        {
            set
            {
                if (value < 10 || value > 150)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Age)} must be between 10 and 150.", nameof(Age));
                }

                m_age = value;
            }

            get
            {
                return m_age;
            }
        }

        public ActivityType Activety { set; get;}

        public User() { }
    }
}
