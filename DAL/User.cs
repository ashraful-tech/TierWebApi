//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Admins = new HashSet<Admin>();
            this.Buyers = new HashSet<Buyer>();
            this.Sellers = new HashSet<Seller>();
        }
    
        public int userId { get; set; }
        public string name { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Buyer> Buyers { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
