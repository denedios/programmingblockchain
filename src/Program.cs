using System;
using NBitcoin;

namespace programmingblockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\nBitcoin Address--------------\n");
            
            var privateKey = new Key().GetWif(Network.Main);
            Console.WriteLine($"Private key: {privateKey}");

            var publicKey = privateKey.PubKey;
            Console.WriteLine($"Public key: {publicKey}");

            var publicKeyHash = publicKey.Hash;
            Console.WriteLine($"Public key hash: {publicKeyHash}");

            var mainNetAddress = publicKeyHash.GetAddress(Network.Main);
            Console.WriteLine($"Main net address: {mainNetAddress}");

            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);
            Console.WriteLine($"Test net address: {testNetAddress}");

            Console.WriteLine("\nScript Pub Key--------------\n");

            var mainScriptPubKey = mainNetAddress.ScriptPubKey;
            Console.WriteLine($"Main ScriptPubKey: {mainScriptPubKey}");

            var testNetScriptPubKey = testNetAddress.ScriptPubKey;
            Console.WriteLine($"Main ScriptPubKey: {testNetScriptPubKey}");

            var paymentScript = publicKeyHash.ScriptPubKey;
            var sameMainNetAddress = paymentScript.GetDestinationAddress(Network.Main);
            Console.WriteLine(mainNetAddress == sameMainNetAddress); // True

            var samePublicKeyHash = (KeyId) paymentScript.GetDestination();
            Console.WriteLine(publicKeyHash == samePublicKeyHash); // true

            var sameMainNetAddress2 = new BitcoinPubKeyAddress(samePublicKeyHash, Network.Main);
            Console.WriteLine(mainNetAddress == sameMainNetAddress2);

            Console.WriteLine("\nPrivate Key--------------\n");








            Console.WriteLine();
            
        }
    }
}
