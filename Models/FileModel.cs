using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace u20676736_HW03.Models
{
    public class FileModel
    {
        public String FileName { get; set; }
        
        public Uri Images { get; set; }
        public Uri Videos { get; set; }
    }
}