using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Blog : BaseEntity
    {
        public Blog()
        {
            CreatedDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
        public string Header { get; set; }
        public string Body { get; set; }
        public string PicturePath { get; set; }
        public string CreatedDate { get; set; }

    }
}
