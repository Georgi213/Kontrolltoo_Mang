using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Ese : Entity
    {
        int puntkideArv;
        string nimetus;

        public Ese(int puntkideArv, string nimetus)
        {
            this.puntkideArv = puntkideArv;
            this.nimetus = nimetus;
        }

        public int PuntkideArv() { return puntkideArv; }
        public string Info() { return nimetus; }
    }
}
