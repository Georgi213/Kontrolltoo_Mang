using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    public static Random rnd = new Random();
    internal class MainClass
    {

        static public void PlayGame(int plrCount)
        {
            Character[] plrs = populatePlayers(plrCount);
            Game mang = new Game(plrs);
            foreach (Character winner in mang.SuurimaEsemeArvu())
            {
                Console.WriteLine(winner.Info());
            }
            Console.WriteLine(mang.SuurimaPunktideArvuga().Info());

        }

        static Character[] populatePlayers(int plrCount)
        {
            if (plrCount < 4) throw new Exception();
            Character[] plrs = new Character[plrCount];
            for (int i = 0; i < plrCount; i++)
            {
                Character plr = new Character(getName());
                plrs[i] = plr;
            }

            return giveOutItems(plrs);
        }

        static Character[] giveOutItems(Character[] plrs)
        {
            List<Ese> itemList = LoeEsemed();
            foreach (Character plr in plrs)
            {
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    plr.Equip(itemList[i]);
                }
            }
            return plrs;
        }
        static int stringToInt(string s)
        {
            int y = 0;
            int total = 0;
            for (int i = 0; i < s.Length; i++)
                y = y * 10 + (s[i] - '0');
            total += y;
            return total;
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        static string getName()
        {
            string[] names = { "avfsd", "fdsf", "cvbc", "vbc", "gff", "ewrw", "rp,", "hgjg", "fgd", "lvbn", "dfgd" };
            return names[rnd.Next(names.Length)];
        }


        public void Equip(Ese item) { items.Add(item); }
    }
}
