using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loginwebapi.Models
{
    public class Bal
    {
        public string GetLogin(Login login)
        {
            Dal dal = new Dal();
            string response = dal.GetLogin(login);
            return response;
        }

    }
}