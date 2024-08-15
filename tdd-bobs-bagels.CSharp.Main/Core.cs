using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _basket = new List<string>();
        public bool Add(string v)
        {
            int count = _basket.Count;
            _basket.Add(v);
            return _basket.Count == count + 1 ? true : false ;

        }

        public bool Delete(string v)
        {
            _basket.Remove(v);
            return true;
        }
    }
}
