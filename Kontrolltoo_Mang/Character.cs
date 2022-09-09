using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Character : Entity, IComparable<Character>
    {

        string nimi;
        List<Ese> items;

        public Character(string nimi)
        {
            items = new List<Ese>();
            this.nimi = nimi;
        }
        public string Info()
        {
            return $"{this.nimi} info:\n" +
                $"Esemete arv: {items.Count}\n" +
                $"Punktide arv: {PuntkideArv()}\n";
        }

        public int PuntkideArv()
        {
            int sum = 0;
            foreach (Ese item in items) { sum += item.PuntkideArv(); }
            return sum;
        }
        public int CompareTo(Character? other)
        {
            if (other == null) return 1;
            return this.items.Count - other.ItemCount();
        }
        public int ItemCount() { return items.Count; }

        public int PuntkideArv()
        {
            int sum = 0;
            foreach (Ese item in items) { sum += item.PuntkideArv(); }
            return sum;
        }

        public void esemeteväljaanne()
        {
            foreach (Ese item in items)
            {
                Console.WriteLine(item.Info() + " " + item.PuntkideArv());
            }
        }


    }
}
