using ManagerGpsMap.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerGpsMap.ViewModels
{
    public class TheoDoiVM : BaseViewModel
    {
    private readonly IPageHelper _pageHelper;
    public TheoDoiVM(IPageHelper pageHelper) {
      _pageHelper = pageHelper;
    }
  }
}
