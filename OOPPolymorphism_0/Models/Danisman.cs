﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0.Models
{
    public class Danisman : Personel
    {
        public override void Calis()
        {
            MessageBox.Show("Ogrenci kaydı al");
        }
    }
}
