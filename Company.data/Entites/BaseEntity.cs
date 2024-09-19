using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.data.Model
{
    public class BaseEntity
    {
    
        public DateTime createdAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
