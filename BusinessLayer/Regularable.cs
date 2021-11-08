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
        [XmlIgnore]
        public Predicate<Regularable> Rules;

        public Regularable() { }
        public bool Validate()
        {
            return Rules(this);
        }
    }
}
