using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class DAO
    {
        private DataBase m_dataBase;

        public DAO(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            m_dataBase = DataBase.Instance;
            m_dataBase.Deserialize(path);
        }
    }
}
