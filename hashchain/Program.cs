using System;
using System.Security.Cryptography;

namespace hashchain {
  internal static class Program {
    private static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      //해시체인 길이
      const int hashchainLength = 1000_0000;
      // var hashchain = new string[hashchainLength];
      //해시체인 시드
      var randomBytes = new byte[1000];
      using var c = new RNGCryptoServiceProvider();
      //시드 생성
      c.GetBytes(randomBytes);
      var previousHash = randomBytes;
      using var mySha256 = SHA256.Create();
      //해시체인 생성
      for (var i = 0; i < hashchainLength; i++) {
        previousHash = mySha256.ComputeHash(previousHash);
        // var hashString = BitConverter.ToString(previousHash).Replace("-", string.Empty).ToLower();
        // hashchain[i] = hashString;
      }
      Console.WriteLine("done");
    }
  }
}