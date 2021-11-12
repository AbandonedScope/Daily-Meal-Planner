using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusinessLayer
{
    public abstract class Regularable
    {
        public delegate void Rules(Regularable ob, ref string message, ref bool flag);

        private Rules validate;

        public Rules Validate
        {
            protected set
            {
                validate = value;
            }

            get
            {
                return validate;
            }
        }
       
    }
}
