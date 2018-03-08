using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServicedinhvi.Models;

namespace WcfServicedinhvi {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
  public class Service1: IService1 {
    WcfServicedinhvi.ServiceRefGps.TTASIServiceClient wcf = new ServiceRefGps.TTASIServiceClient();

    /// <summary>
    /// 1.	Login form
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns>
    /// 	Status as string data. 200 it mean OK else we will show message via property Message and Status value
    /// 	Message as string data.In the case Status is 200, Message will Empty
    /// 	Group_id  as string data
    /// 	User_group as string data
    /// 	Kpi as string data
    /// </returns>
    public login fn_login(string username,string password) {
      var model= wcf.fn_login(username,password);
      return new login() {
        Kpi = model.Kpi,
        Group_id = model.Group_id,
        User_group = model.User_group,
        Status = model.Status,
        Message = model.Message,
        username = model.Username
      };
    }

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
  }
}
