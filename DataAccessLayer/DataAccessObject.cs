using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace DataAccessLayer
{
    public abstract class DataAccessObject
    {
        protected DataBase? m_dataBase;

        public DataAccessObject(string path)
        {
            m_dataBase = DataBase.Instance;
            m_dataBase.Deserialize(path);
        }
    }
}
