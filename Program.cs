using System;
using System.IO;
using System.Security.Cryptography;

namespace SHA256test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SHA256 mySHA = SHA256.Create())
            {
                try
                {
                    byte[] hashValue = mySHA.ComputeHash(File.ReadAllBytes("C:\\Users\\abcd8\\Documents\\test2.txt"));
                    
                    foreach (byte b in hashValue)
                        Console.Write($"{b:x}");
                }
                catch (IOException e) {
                    Console.WriteLine($"I/O Exception: {e.Message}");
                }
                catch (UnauthorizedAccessException e) {
                    Console.WriteLine($"Access Exception: {e.Message}");
                }
                Console.Write("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
