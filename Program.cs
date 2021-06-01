using System;
using System.IO;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("input.txt") )
            {
                string line = await sr.ReadLineAsync();

                using (StreamWriter wrt = new StreamWriter("output.txt")) 
                {
                    int count = 1;

                    while (line != null)
                    {
                        await wrt.WriteAsync($"{count}. {line}");
                        count++;
                        line = await sr.ReadLineAsync();
                    }
                }  
            }
        }
    }
}
