using ManagerGpsMap.Common.Helpers;
using ManagerGpsMap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManagerGpsMap.Views {
	  [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TheoDoiPage
	{
    public TheoDoiVM vm {
      get => BindingContext as TheoDoiVM;
      set => BindingContext = value;
    }

    public TheoDoiPage ()
		{
      vm = new TheoDoiVM(new PageHelper());
      InitializeComponent ();
		}
	}
}