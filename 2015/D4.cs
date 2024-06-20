using System.Security.Cryptography;
using System.Text;

string input = "ckczppom";

int output = 0;
string hash;

do 
{
    output++;
    byte[] bytes = Encoding.ASCII.GetBytes(input + output);
    bytes = MD5.Create().ComputeHash(bytes);
    hash = string.Join("", bytes.Select(a => a.ToString("x2")));
    
    Console.WriteLine(input + output + " " + hash);
} while (!hash.StartsWith("000000"));