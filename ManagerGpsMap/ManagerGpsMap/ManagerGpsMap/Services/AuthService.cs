using ManagerGpsMap.Common.Helpers;
using ManagerGpsMap.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi;
using WcfServicedinhvi.Data;
using WcfServicedinhvi.Models;

namespace ManagerGpsMap.Services
{
  public class AuthService: IAuthService {
    private readonly ISoapService _soapService;

    public AuthService(ISoapService soapService) {
      this._soapService = soapService;
    }

    public Task<login> Login(string username, string password) {

      _soapService.Login(username,password);
      throw new NotImplementedException();
    }
  }
}

