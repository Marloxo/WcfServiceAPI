namespace WcfServiceAPI.Core
{
   public class TokenValidator
   {
      public bool IsValid(string token)
      {
         return TokenBuilder.StaticToken == token;
      }
   }
}