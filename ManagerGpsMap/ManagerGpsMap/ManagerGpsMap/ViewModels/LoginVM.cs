﻿using ManagerGpsMap.Common.Helpers;
using ManagerGpsMap.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WcfServicedinhvi.Models;
using Xamarin.Forms;

namespace ManagerGpsMap.ViewModels {
  public class loginVM: BaseViewModel {
    private readonly IPageHelper _pageHelper;
    private readonly IAuthService _authService;

    private bool _isLoading;
    public bool IsLoading {
      get => _isLoading;
      set => SetValue(ref _isLoading, value);
    }

    private string _userName = "vothanhtam";
    public string UserName {
      get => _userName;
      set => SetValue(ref _userName, value);
    }

    private string _password = "123456";
    public string Password {
      get => _password;
      set => SetValue(ref _password, value);
    }

    public ICommand LoginCommand { get; set; }

    public loginVM(IPageHelper pageHelper, IAuthService authService) {
      _pageHelper = pageHelper;
      _authService = authService;
      LoginCommand = new Command(async vm => await Login());
    }
    private async Task Login() {
      IsLoading = true;

      login authData;
      try {
        authData = await _authService.Login(new JiraCredential(_userName, _password));
      } catch(Exception e) {
        await _pageHelper.DisplayAlert("Login Error", e.Message, "OK");
        IsLoading = false;
        return;
      }

      if(authData != null) {
        await _jiraCredentialHelper.StoreCredential(_userName, authData.Token);

        await _pageHelper.PushAsync(new TabbedBasePage());

        return;
      }

      IsLoading = false;
      await _pageHelper.DisplayAlert("Login Error", "Login failed", "OK");
    }
  }
}
