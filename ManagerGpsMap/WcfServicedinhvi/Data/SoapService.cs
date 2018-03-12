using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServicedinhvi.ContractTypes;
using WcfServicedinhvi.ServiceRefGps;

namespace WcfServicedinhvi.Data {

  public class SoapService: ISoapService {
    TTASIServiceClient _tTASIServiceClient;

    public SoapService() {
        _tTASIServiceClient = new TTASIServiceClient(
        new BasicHttpBinding(),
        new EndpointAddress(Constants.SoapUrl));
    
  }

    async Task<WcfServicedinhvi.ServiceRefGps.Resp_Login> ISoapService.Login(string username, string password) {
      return await _tTASIServiceClient.fn_loginAsync(username, password);
    }
  }
}
