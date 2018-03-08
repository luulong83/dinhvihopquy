using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi.Models;

namespace ManagerGpsMap.Services
{
  public interface IAuthService {
    Task<login> Login(string username, string password);
  }
}
