using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class LoginRequest
    {
        public string Username { get; set; } = null!;
        public string Pasword { get; set; } = null!;
    }
}
