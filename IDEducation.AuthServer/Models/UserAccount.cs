//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDEducation.AuthServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        public UserAccount()
        {
            this.UserClaims = new HashSet<UserClaim>();
        }
    
        public System.Guid UserAccountId { get; set; }
        public string UserName { get; set; }
        public AccountStatus Status { get; set; }
    
        public virtual Profile Profile { get; set; }
        public virtual ICollection<UserClaim> UserClaims { get; set; }
    }
}
