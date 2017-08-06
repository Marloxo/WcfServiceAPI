using System.ServiceModel;
using System.ServiceModel.Web;
using WcfServiceAPI.Models;

namespace WcfServiceAPI
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
   // Fiddler Call Header : { Content-Type: application/json; charset=UTF-8}
   [ServiceContract]
   public interface IService1
   {
      [OperationContract]
      string GetData(int value);

      [OperationContract]
      CompositeType GetDataUsingDataContract(CompositeType composite);

      // TODO: Add your service operations here

      [OperationContract]
      [WebInvoke(Method = "POST",
      BodyStyle = WebMessageBodyStyle.Wrapped,
      RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "Hello")]
      string HelloUser(string user);

      [OperationContract]
      [WebInvoke(Method = "Get",
      BodyStyle = WebMessageBodyStyle.Wrapped,
      RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "GetHello/{user}")]
      string GetHelloUser(string user);

      [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "Authenticate")] /* {"User":"user1","Password":"pass1"} */
      [OperationContract]
      string Authenticate(Credentials creds);

      [OperationContract]
      [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
      UriTemplate = "Test")]
      string Test();

   }
}
