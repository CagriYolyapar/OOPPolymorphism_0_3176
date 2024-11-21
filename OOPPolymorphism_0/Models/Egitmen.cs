using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0.Models
{
    public class Egitmen : Personel
    {
        public override void Calis()
        {
            MessageBox.Show("Ders anlat");
        }


        public void Deneme()
        {

        }
    }
}
