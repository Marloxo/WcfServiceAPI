using System.Runtime.Serialization;

namespace WcfServiceAPI.Models
{
   [DataContract]
   public class Credentials
   {
      public string User { get; set; }
      public string Password { get; set; }
   }
}