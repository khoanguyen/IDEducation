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
    
    public partial class Profile
    {
        public System.Guid UserAccountId { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    
        public virtual UserAccount UserAccount { get; set; }
    }
}
