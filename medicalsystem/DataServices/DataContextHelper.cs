using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicalsystem.DataServices
{
    public class DataContextHelper
    {
        public static PetaPoco.Database GetContext() {
            return new PetaPoco.Database("constrng");
        }
    }
}