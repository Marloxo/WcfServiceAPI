using System;
using WcfServiceAPI.Models;

namespace WcfServiceAPI.Core
{//REF: https://www.codeproject.com/Articles/1084143/Authentication-Token-Service-for-WCF-Services-Part
   public class TokenBuilder
   {
      internal static string StaticToken = "{B709CE08-D2DE-4201-962B-3BBAC74C5952}";
      public string Build(Credentials creds)
      {
         if (new CredentialsValidator().IsValid(creds))
            return StaticToken;
         throw new AccessViolationException();
      }
   }
}