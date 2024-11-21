using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism_0.Tools
{
    public class Bateri : Enstruman
    {
        public override string Materyal
        {
            get
            {
                return _materyal;
            }
            set
            {
                if (value.Length < 6) throw new Exception("6 karakterden az veri giremezsiniz");
            }
        }
    }
}

