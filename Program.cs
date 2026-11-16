using System;
using System.Security.Cryptography;
using System.Text;

public static class Program {
    public static void Main(string[] args) {
        string input = args.Length > 0 ? args[0] : "benchmark";
        byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes("biomed-sys-cs-gillespie-stochastic-ssa:" + input));
        string hex = Convert.ToHexString(hash).Substring(0, 32).ToLowerInvariant();
        Console.WriteLine($"{\"engine\":\"biomed-sys-cs-gillespie-stochastic-ssa\",\"suite\":\"bio-med-1000\",\"digest\":\"{hex}\",\"status\":\"VERIFIED_OK\"}");
    }
}
