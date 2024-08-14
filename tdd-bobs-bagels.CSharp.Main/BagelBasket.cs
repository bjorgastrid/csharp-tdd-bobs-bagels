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

        public bool add(string bagel)
        {
            bagles.Add(bagel);

            return true;
        }

        public bool remove(string bagel)
        {
            bagles.Remove(bagel);

            return false;
        }

    }
}
