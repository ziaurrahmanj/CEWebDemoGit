// Type: SageSSO.ServiceReferences.RemoteScriptingServiceSoapClient
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SageSSO.ServiceReferences
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public class RemoteScriptingServiceSoapClient : ClientBase<IRemoteScriptingServiceSoap>, IRemoteScriptingServiceSoap
  {
    public RemoteScriptingServiceSoapClient()
    {
    }

    public RemoteScriptingServiceSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public RemoteScriptingServiceSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public RemoteScriptingServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public RemoteScriptingServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public ExecuteScriptResponse ExecuteScript(ExecuteScriptRequest request)
    {
      return this.Channel.ExecuteScript(request);
    }

    public GetScriptResultResponse GetScriptResult(GetScriptResultRequest request)
    {
      return this.Channel.GetScriptResult(request);
    }
  }
}
