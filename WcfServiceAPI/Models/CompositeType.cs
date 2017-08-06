using System.Runtime.Serialization;

namespace WcfServiceAPI.Models
{   // Use a data contract as illustrated in the sample below to add composite types to service operations.
   [DataContract]
   public class CompositeType
   {
      [DataMember]
      public bool BoolValue { get; set; }

      [DataMember]
      public string StringValue { get; set; }

   }
}