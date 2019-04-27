using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public class People
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string MobilePhone { get; set; }
        public string Name { get; set; }
    }
}
