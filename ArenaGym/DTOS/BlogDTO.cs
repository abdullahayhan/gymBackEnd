using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArenaGym.DTOS
{
    public class BlogDTO
    {    
        [Required]
        public string Header { get; set; }
        [Required]
        public string Body { get; set; }
        public string PicturePath { get; set; }
    }
}
