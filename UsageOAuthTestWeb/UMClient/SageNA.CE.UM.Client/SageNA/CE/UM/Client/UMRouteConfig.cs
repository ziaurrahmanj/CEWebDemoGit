// Type: SageNA.CE.UM.Client.UMRouteConfig
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.Web.Mvc;
using System.Web.Routing;

namespace SageNA.CE.UM.Client
{
  public class UMRouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      RouteCollectionExtensions.MapRoute(routes, "SignOnSuccess", "UM/SSO/SignOnSuccess/{resultId}", (object) new
      {
        controller = "SSO",
        action = "SignOnSuccessful",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "SignOnFail", "UM/SSO/SignOnFail/{resultId}", (object) new
      {
        controller = "SSO",
        action = "SignOnFailed",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "SignOut", "UM/SSO/SignOut", (object) new
      {
        controller = "SSO",
        action = "SignOut"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "SignOutAll", "UM/SSO/SignOutAll", (object) new
      {
        controller = "SSO",
        action = "SignOutAll"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "SignOnInit", "UM/SSO/SignOnInit", (object) new
      {
        controller = "SSO",
        action = "SignOnInit"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "SignUpInit", "UM/SSO/SignUpInit/{emailReference}", (object) new
      {
        controller = "SSO",
        action = "SignUpInit",
        emailReference = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "ChangePassword", "UM/SSO/ChangePassword", (object) new
      {
        controller = "SSO",
        action = "ChangePassword"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "ChangePasswordResult", "UM/SSO/ChangePasswordResult/{resultId}", (object) new
      {
        controller = "SSO",
        action = "ChangePasswordResult",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "ManageAuthorisations", "UM/SSO/ManageAuthorisations", (object) new
      {
        controller = "SSO",
        action = "ManageAuthorisations"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "ManageAuthorisationsResult", "UM/SSO/ManageAuthorisationsResult/{resultId}", (object) new
      {
        controller = "SSO",
        action = "ManageAuthorisationsResult",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "RegisterNew", "UM/SSO/RegisterNew", (object) new
      {
        controller = "SSO",
        action = "RegisterNew"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "RegisterNewResult", "UM/SSO/RegisterNewResult/{resultId}", (object) new
      {
        controller = "SSO",
        action = "RegisterNewResult",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "RegisterExisting", "UM/SSO/RegisterExisting", (object) new
      {
        controller = "SSO",
        action = "RegisterExisting"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "RegisterExistingResult", "UM/SSO/RegisterExistingResult/{resultId}", (object) new
      {
        controller = "SSO",
        action = "RegisterExistingResult",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "SSONotify", "UM/SSO/Notify", (object) new
      {
        controller = "SSO",
        action = "SSONotify"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "Activation", "UM/SSO/Activation/{resultId}", (object) new
      {
        controller = "SSO",
        action = "Activation",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "ProcessActivation", "UM/SSO/ProcessActivation/{resultId}", (object) new
      {
        controller = "SSO",
        action = "Activation",
        resultId = ""
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
      RouteCollectionExtensions.MapRoute(routes, "Trace", "UM/SSO/Trace", (object) new
      {
        controller = "SSO",
        action = "Trace"
      }, new string[1]
      {
        "SageNA.CE.UM.Client"
      });
    }
  }
}
