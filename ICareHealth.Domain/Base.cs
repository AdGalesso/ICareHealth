using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Domain
{
    public class Base<T> where T : struct
    {
        public T Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime Save { get; set; }

        public DateTime Update { get; set; }

        public Base()
        {
            Save = DateTime.Now;
            Update = DateTime.Now;
            IsActive = true;
        }
    }
}
