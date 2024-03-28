using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBUSSNIES
{
    public interface IAuthBussnies
    {
        LoginResponse Login(LoginRequest request);
    }
}
