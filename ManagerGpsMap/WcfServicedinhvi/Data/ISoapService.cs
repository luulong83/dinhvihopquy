using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi.ContractTypes;
using WcfServicedinhvi.Models;

namespace WcfServicedinhvi.Data {
  public interface ISoapService {
    Task<WcfServicedinhvi.ServiceRefGps.Resp_Login> Login(string username, string password);
  }
}
