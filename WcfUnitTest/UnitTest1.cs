using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceAPI.Core;

namespace WcfUnitTest
{//REF: http://www.rhyous.com/2015/01/30/a-c-class-to-easily-create-an-md5-sha1-sha256-or-sha512-hash
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void MD5Test()
      {
         // Arrange
         const string tobehashed = "1";
         // Got comparison hash from here: http://www.xorbin.com/tools/md5-hash-calculator
         // Also verified with md5sums.exe
         const string expectedHash = "c4ca4238a0b923820dcc509a6f75849b";

         // Act
         string actualHash = Hash.Get(tobehashed, Hash.HashType.MD5);

         // Assert
         Assert.AreEqual(expectedHash, actualHash);
      }

      [TestMethod]
      public void Sha1Test()
      {
         // Arrange
         const string tobehashed = "1";
         // Got comparison hash from here: http://www.xorbin.com/tools/sha1-hash-calculator
         // Also verified with sha1sums.exe
         const string expectedHash = "356a192b7913b04c54574d18c28d46e6395428ab";

         // Act
         string actualHash = Hash.Get(tobehashed, Hash.HashType.SHA1);

         // Assert
         Assert.AreEqual(expectedHash, actualHash);
      }

      [TestMethod]
      public void Sha256Test()
      {
         // Arrange
         const string tobehashed = "1";
         // Got comparison hash from here: http://www.xorbin.com/tools/sha256-hash-calculator
         // Also verified with sha1sums.exe
         const string expectedHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b";

         // Act
         string actualHash = Hash.Get(tobehashed, Hash.HashType.SHA256);

         // Assert
         Assert.AreEqual(expectedHash, actualHash);
      }

      [TestMethod]
      public void Sha512Test()
      {
         // Arrange
         const string tobehashed = "1";
         // Got comparison hash from here:  http://www.miniwebtool.com/sha512-hash-generator/
         const string expectedHash = "4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a";

         // Act
         string actualHash = Hash.Get(tobehashed, Hash.HashType.SHA512);

         // Assert
         Assert.AreEqual(expectedHash, actualHash);
      }
   }
}