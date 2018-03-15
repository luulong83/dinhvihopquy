using ManagerGpsMap.Common.Helpers;
using ManagerGpsMap.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi;
using WcfServicedinhvi.Models;

namespace ManagerGpsMap.Services
{
  public class AuthService: IAuthService {
    private readonly Service1 _soapService;

    public AuthService(Service1 soapService) {
      this._soapService = soapService;
    }

    public Task<login> Login(string username, string password) {
      return Task.FromResult(_soapService.fn_login(username,password));
    }
  }
}

