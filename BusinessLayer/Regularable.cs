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
        public HashSet<Predicate<Regularable>> m_rules;
        public List<string> m_messeges;

        public Regularable() { }

        public void AddRule(string messegeAboutMistake, Predicate<Regularable> rule)
        {
            m_rules.Add(rule);
            m_messeges.Add(messegeAboutMistake);
        }

        public bool RemoveRule(Predicate<Regularable> rule)
        {
            int i = 0;
            bool flag = false;
            foreach (Predicate<Regularable> pred in m_rules)
            {
                if (pred == rule)
                {
                    flag = true;
                    break;
                }
                i++;
            }

            if (flag)
            {
                m_rules.Remove(rule);
                m_messeges.RemoveAt(i);
                return true;
            }

            return false;
        }

        public bool Validate(out string messege)
        {
            int i = 0;
            foreach(Predicate<Regularable> rule in m_rules)
            {
                if(!rule(this))
                {
                    messege = m_messeges[i];
                    return false;
                }
                i++;
            }

            messege = string.Empty;
            return true;
        }
    }
}
