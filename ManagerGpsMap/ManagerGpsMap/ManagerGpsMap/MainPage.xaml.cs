using ManagerGpsMap.Models;
using ManagerGpsMap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManagerGpsMap
{
	
	public partial class MainPage : TabbedPage  {
    public MainPage ()
		{
			InitializeComponent ();

    }
    protected override void OnCurrentPageChanged() {
      base.OnCurrentPageChanged();
      Title = CurrentPage?.Title;
    }
  }
}