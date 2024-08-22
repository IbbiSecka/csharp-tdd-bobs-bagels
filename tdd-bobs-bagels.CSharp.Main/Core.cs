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
            if (_basket.Contains(v)) {
                _basket.Remove(v);
                return true;
            }
           
            return false;
        }
        public bool maxCapacity(List<string> _basket)
        {
            int maxCapacity = 1;
            if(_basket.Count > maxCapacity)
            {
                return false;
            }
            return true;
        }
        public int totalItems { get { return _basket.Count; } }
        public int MaxCapacity { get; set; } = 3;
        public int changeCapacity(int MaxCapacity) {

            return MaxCapacity = 1;

        }
    }
}
