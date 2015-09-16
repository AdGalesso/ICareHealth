using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Domain
{
    public class Plan : Base<int>
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public void SetPromotionalValue(int age)
        {
            if (age > 65)
                Value = Value / 2;
        }
    }
}
