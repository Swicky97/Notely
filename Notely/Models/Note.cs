using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notely.Models
{
    public class Note
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
