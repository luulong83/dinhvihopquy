using ManagerGpsMap.Common.Constants;
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

namespace ManagerGpsMap.Views {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class LoginPage: ContentPage {
    PageHelper _pageHelper = new PageHelper();
    public LoginVM vm {
      get => BindingContext as LoginVM;
      set => BindingContext = value;
    }

    public LoginPage() {
      vm = new LoginVM(new PageHelper(), new AuthService(new SoapService()));
        InitializeComponent();
    }

  
  }
}

