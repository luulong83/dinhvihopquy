using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerGpsMap.Models
{
  public class JiraCredential {
    public string UserName { get; set; }
    public string Password { get; set; }

    public JiraCredential(string userName, string password) {
      UserName = userName;
      Password = password;
    }
  }
}
