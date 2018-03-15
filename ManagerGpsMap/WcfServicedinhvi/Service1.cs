using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi.Models;

namespace WcfServicedinhvi {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
  public class Service1: IService1 {

    ServiceReference1.TTASIServiceClient client = new ServiceReference1.TTASIServiceClient();
    public string GetData(int value) {
      return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite) {
      if(composite == null) {
        throw new ArgumentNullException("composite");
      }
      if(composite.BoolValue) {
        composite.StringValue += "Suffix";
      }
      return composite;
    }

    public login fn_login(string username, string password) {
      var model = client.fn_login(username, password);

      return new login() {
        Kpi = model.Kpi,
        Group_id = model.Group_id,
        User_group = model.User_group,
        Status = model.Status,
        Message = model.Message,
        username = model.Username
      };

      //throw new NotImplementedException();
    }
  }
}
