using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Mini_Project.Services
{
    public class MethodService
    {
        public static string GetUserPath(Guid Id)
        {
            return Path.Combine(Constants.PathConst.UserDBPath, Id.ToString() + ".txt");
        }
    }
}
