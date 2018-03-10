using System;
using NBitcoin;

namespace programmingblockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var privateKey = new Key().GetWif(Network.Main);
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Private key: {privateKey}");

            var publicKey = privateKey.PubKey;
            Console.WriteLine($"Public key: {publicKey}");

            var publicKeyHash = publicKey.Hash;
            Console.WriteLine($"Public key hash: {publicKeyHash}");

            var mainNetAddress = publicKeyHash.GetAddress(Network.Main);
            Console.WriteLine($"Main net address: {mainNetAddress}");

            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);
            Console.WriteLine($"Test net address: {testNetAddress}");


            Console.WriteLine();
            
        }
    }
}
