using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBoardFixApp
{
    public static class loginServices
    {
        public static bool login(string id,string password)
        {
            if(id == "admin"&&password =="123456")
            return true;
            else return false;
        }
    }
}
