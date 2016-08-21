using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using medicalsystem;
using constrng;

namespace medicalsystem.DataServices.Services
{
    public class LoginService
    {
        private static LoginService _service = null;

        public static LoginService Instance => _service ?? (_service = new LoginService());

        public bool LoginAuth(string username, string pass) {

            using (var _context = DataContextHelper.GetContext()) {
             var result =   _context.Fetch<tblUser>("select UserName,Password from tblUser where UserName=@0 and Password=@1", username, pass);

             bool returnvalue = false;
                if (result.Count > 0)
                {
                    
                    returnvalue = true;
                }
             return returnvalue;
               
            }
        }
    }
}