using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism_0.Tools
{

    //Materyal'in güvenli bir şekilde sadece Gitar class'ında Encapsulation'a girerek minimum 8 karakter harf almasını saglayın, Bateri class'ında da minimum 6 karakter yapılmasını saglayın...Kod hakimiyeti sizde
    public class Enstruman
    {
        protected string _materyal;
        public virtual string Materyal { get; set; }



    }
}
