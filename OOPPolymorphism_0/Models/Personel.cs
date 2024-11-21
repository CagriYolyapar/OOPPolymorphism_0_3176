using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0.Models
{
    public class Personel
    {

       
        public  string Isim { get; set; }
        public string SoyIsim { get; set; }
        public virtual void Calis()
        {
            MessageBox.Show("Klasik görev");

        }

        public override string ToString()
        {
            return $"{Isim} {SoyIsim}";
        }
    }
}
