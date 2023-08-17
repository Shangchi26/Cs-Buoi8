using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            Console.WriteLine("Nhập vào các chuỗi, nhập chuỗi trống để kết thúc:");
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordFrequency.ContainsKey(word))
                    {
                        wordFrequency[word]++;
                    }
                    else
                    {
                        wordFrequency[word] = 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("\nKết quả:");
            foreach (var kvp in wordFrequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            int totalWords = 0;
            foreach (int count in wordFrequency.Values)
            {
                totalWords += count;
            }
            Console.WriteLine($"\nTổng số từ: {totalWords}");
            Console.ReadKey();
        }
    }
}
