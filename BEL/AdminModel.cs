using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public  class AdminModel
    {
        public int id { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        public int userId { get; set; }

        public virtual UserModel User { get; set; }
    }
}
