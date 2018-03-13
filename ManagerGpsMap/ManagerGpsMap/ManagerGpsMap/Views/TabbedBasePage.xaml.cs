using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManagerGpsMap.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedBasePage : TabbedPage {
		public TabbedBasePage ()
		{
      try {
        InitializeComponent();
      } catch(Exception ex) {

        throw;
      }
			
		}
	}
}