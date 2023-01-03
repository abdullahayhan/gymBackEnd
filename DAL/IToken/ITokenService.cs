using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Itoken
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}
