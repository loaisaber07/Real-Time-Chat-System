using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class User  : IdentityUser
    {
        public byte[]? Image { get; set; }
    }
}
