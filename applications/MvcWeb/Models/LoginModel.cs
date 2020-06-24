using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string SessionKey { get; set; }
        public string SessionID { get; set; }
        public string UserID { get; set; }
        public string BranchId { get; set; }
        public string DisplayName { get; set; }
        public string SessionStatus { get; set; }
        public string AllowDevelop { get; set; }
        public string AllowViewAllData { get; set; }
    }
}
