using System;
using System.ServiceModel.Activation;
using System.Web;
using WcfServiceAPI.Core;
using WcfServiceAPI.Models;

namespace WcfServiceAPI
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

   public class Service1 : IService1
   {
      public string Authenticate(Credentials creds)
      {
         CredentialsValidator validator = new CredentialsValidator();
         if (validator.IsValid(creds))
            return new TokenBuilder().Build(creds);
         throw new InvalidOperationException("Invalid credentials");
      }


      public string Test()
      {
         var token = HttpContext.Current.Request.Headers["Token"];
         TokenValidator validator = new TokenValidator();
         if (validator.IsValid(token))
         {
            return "Your token worked!";
         }
         else
         {
            return "Your token failed!";
         }
      }

      public string GetData(int value)
      {
         return string.Format("You entered: {0}", value);
      }

      public CompositeType GetDataUsingDataContract(CompositeType composite)
      {
         if (composite == null)
         {
            throw new ArgumentNullException("composite");
         }
         if (composite.BoolValue)
         {
            composite.StringValue += "Suffix";
         }
         return composite;
      }

      public string GetHelloUser(string user)
      {
         return "Hello: " + user;
      }

      public string HelloUser(string user)
      {
         return "Hello: " + user;
      }
   }
}
