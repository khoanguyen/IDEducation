using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDEducation.AuthServer.Models
{
    public class FirstRunConfiguration
    {
        [DisplayName("Server Public Key")]
        public string PublicKey { get; private set; }

        [DisplayName("Super Admin Username")]
        [Required]
        [MaxLength(50)]
        public string SuperAdminUsername { get; set; }

        [DisplayName("Super Admin Password")]
        [Required]
        [MaxLength(50)]
        public string SuperAdminPassword { get; set; }

        [DisplayName("Confirm Super Admin Password ")]
        [Required]
        [MaxLength(50)]
        [Compare("SuperAdminPassword")]
        public string ConfirmSuperAdminPassword { get; set; }

        public FirstRunConfiguration()
        {
            PublicKey = "aslkdjdlksajdlsajdlksdh lkjshf hk hfh fh kjhfhkjd ldj ;lfjalfjds lfjdsa;l fjadlkf j;la jfjflaaslkdjdlksajdlsajdlksdh lkjshf hk hfh fh kjhfhkjd ldj ;lfjalfjds lfjdsa;l fjadlkf j;la jfjflaaslkdjdlksajdlsajdlksdh lkjshf hk hfh fh kjhfhkjd ldj ;lfjalfjds lfjdsa;l fjadlkf j;la jfjflaaslkdjdlksajdlsajdlksdh lkjshf hk hfh fh kjhfhkjd ldj ;lfjalfjds lfjdsa;l fjadlkf j;la jfjflaaslkdjdlksajdlsajdlksdh lkjshf hk hfh fh kjhfhkjd ldj ;lfjalfjds lfjdsa;l fjadlkf j;la jfjfla";
        }
    }
}