using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class Regularable
    {
        public Predicate<Regularable> Rules;

        public bool Validate()
        {
            return Rules(this);
        }
    }
}
