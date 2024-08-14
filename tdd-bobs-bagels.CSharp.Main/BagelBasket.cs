using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class BagelBasket
{
        public List<string> bagles = new List<string>();

        public int capacity = 1;

        public bool add(string bagel)
        {
            if (bagles.Count < capacity)
            {

            bagles.Add(bagel);
            return true;

            }

            return false;
        }

        public bool remove(string bagel)
        {
            bagles.Remove(bagel);

            return false;
        }

    }
}
