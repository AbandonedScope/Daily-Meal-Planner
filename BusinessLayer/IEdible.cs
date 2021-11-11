using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    interface IEdible
    {
        public float Calories { get; }

        public float Carbs { get; }

        public float Protein { get; }

        public float Fats { get; }

    }
}
