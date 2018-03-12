﻿using ManagerGpsMap.Common.Constants;
using ManagerGpsMap.Common.Helpers;
using ManagerGpsMap.Services;
using ManagerGpsMap.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WcfServicedinhvi.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManagerGpsMap.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class LoginPage: ContentPage {

    PageHelper _pageHelper = new PageHelper();

    public LoginViewModel vm {
      get => BindingContext as LoginViewModel;
      set => BindingContext = value;
    }

    public LoginPage() {
      vm = new LoginViewModel(new PageHelper(), new AuthService(new SoapService()));
      try {
        InitializeComponent();
        ImageSource x = ImageSource.FromFile("logo_vnpt.png");

        // Load username and password stored
        //if(Device.RuntimePlatform == Device.Android) {
        //teUserName.Text = _credentialsService.UserName;
        //tePassword.Text = _credentialsService.Password;
        //} else if(Device.RuntimePlatform == Device.iOS) {

        //  string value = NSUserDefaults.StandardUserDefaults.StringForKey("Username");
        //if(value != null) teUserName.Text = value;
        //value = NSUserDefaults.StandardUserDefaults.StringForKey("Password");
        //if(value != null) tePassword.Text = value;
        //}


      } catch(System.Exception ex) {

        throw;
      }
    }
    async void DangNhap() {
      //btDangnhap.IsEnabled = false;
      //if(teUserName.Text == null || teUserName.Text.Trim() == "" || tePassword.Text == null || tePassword.Text.Trim() == "") {
      //  lbStatus.Text = "Tên đăng nhập và mật khẩu không được để rỗng, vui lòng thử lại!";
      //  btDangnhap.IsEnabled = true;
      //  return;
      //}
      var login = LoginAsync();
      bool fl = await login;

     
      //if(fl) {
        // Store ID of Benh Vien
        //SaveCredentials(txtUsernameEnt.Text, txtPasswordEnt.Text);
        //App.HospitalID = _hospitalId;
        //lbStatus.Text = "Đăng nhập thành công!";
        //btDangnhap.IsEnabled = true;
        //Device.BeginInvokeOnMainThread(() => App.Current.MainPage = new NavigationPage(new RootPage()));
        var task = _pageHelper.PushAsync(new MainPage());
        await task;

        // Authorization
        //UserPermission(userLevel);
      //} else {
        //lbStatus.Text = "Tên đăng nhập hoặc mật khẩu không đúng, vui lòng thử lại!";
        //btDangnhap.IsEnabled = true;
        return;
     // }

    }

    //public void SaveCredentials(string userName, string password) {
    //  if(Device.RuntimePlatform == Device.Android) {
    //    _credentialsService.SaveCredentials(userName, password);
    //  } else if(Device.RuntimePlatform == Device.iOS) {
    //    NSUserDefaults.StandardUserDefaults.SetString(userName, "Username");
    //    NSUserDefaults.StandardUserDefaults.SetString(password, "Password");
    //    NSUserDefaults.StandardUserDefaults.Synchronize();
    //  }
    //}

    public async Task<bool> LoginAsync() {
      try {
        //var dangNhapVM = new DangNhapViewModel {
        //  Username = teUserName.Text,
        //  Password = tePassword.Text,
        //  ID = _hospitalId
        //};

        ////Response data
        //var benhVien = _danhNhapVM.Login(dangNhapVM);
        //var benhVienData = await benhVien;

        //if(benhVienData != null) {
        //  App.HospitalID = benhVienData.HOSPITAL_ID;
        //  return true;
        //}

        // Authorization
        //switch (dangNhapVM.Username)
        //{
        //    case "admin":
        //        Authorization("0");
        //        break;
        //    case "bacsi":
        //        Authorization("1");
        //        break;
        //    case "benhnhan":
        //        Authorization("2");
        //        break;
        //    default:
        //        break;
        //}
        //if (benhVienData != null)
        //{
        //    App.HospitalID = benhVienData.HOSPITAL_ID;
        //    userLevel = benhVienData.USER_LEVEL;
        //    return true;
        //}
        //// Authorization - DanhTC

        return true;
      } catch(Exception) {
        var task = DisplayAlert(AppConstant.Error, AppConstant.Message, AppConstant.Cancel);
        await task;
        return false;
      }
    }
  }
}
