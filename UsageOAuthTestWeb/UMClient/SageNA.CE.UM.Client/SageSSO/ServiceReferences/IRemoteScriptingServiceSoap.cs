// Type: SageSSO.ServiceReferences.IRemoteScriptingServiceSoap
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SageSSO.ServiceReferences
{
  [ServiceContract(ConfigurationName = "SageSSO.ServiceReferences.IRemoteScriptingServiceSoap", Namespace = "http://sso.sage.com", SessionMode = SessionMode.NotAllowed)]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public interface IRemoteScriptingServiceSoap
  {
    [OperationContract(Action = "http://sso.sage.com/IRemoteScriptingServiceSoap/ExecuteScript", ReplyAction = "http://sso.sage.com/IRemoteScriptingServiceSoap/ExecuteScriptResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    ExecuteScriptResponse ExecuteScript(ExecuteScriptRequest request);

    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IRemoteScriptingServiceSoap/GetScriptResult", ReplyAction = "http://sso.sage.com/IRemoteScriptingServiceSoap/GetScriptResultResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    GetScriptResultResponse GetScriptResult(GetScriptResultRequest request);
  }
}
