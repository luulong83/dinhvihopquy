using ManagerGpsMap.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi.Models;

namespace ManagerGpsMap.Services
{
  public class AuthService: IAuthService {
    private readonly IHttpClientHelper _httpClientHelper;

    public AuthService(IHttpClientHelper httpClientHelper) {
      _httpClientHelper = httpClientHelper;
    }

    public async Task<AuthData> Login(JiraCredential jiraCredential) {
      var loginApi = $"{AppConstant.BaseUrl}api/auth/login";

      return await _httpClientHelper.PostAsync<JiraCredential, AuthData>(_httpClient, loginApi, jiraCredential);
    }

    public Task<login> Login(string username, string password) {
      throw new NotImplementedException();
    }
  }
}

