using System.Runtime.Serialization;

namespace WcfServiceAPI.Models
{
   [DataContract]
   public class Result<T>
   {
      [DataMember(Order = 0)]
      public int Code { get; set; }

      [DataMember(Order = 1)]
      public int Message { get; set; }

      [DataMember(Order = 2)]
      public T Data { get; set; }
   }
}