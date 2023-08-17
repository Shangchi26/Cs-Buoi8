using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bai2
{
    internal class Program
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int choice = 0;

            do
            {
                Console.WriteLine("Từ điển Anh - Việt");
                Console.WriteLine("1. Thêm từ mới");
                Console.WriteLine("2. Hiển thị toàn bộ");
                Console.WriteLine("3. Tra từ");
                Console.WriteLine("4. Sửa từ");
                Console.WriteLine("5. Xóa từ");
                Console.WriteLine("6. Thoát");
                Console.Write("Mời bạn chọn (1-6): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddNewWord();
                            break;
                        case 2:
                            DisplayAllWords();
                            break;
                        case 3:
                            SearchWord();
                            break;
                        case 4:
                            EditWord();
                            break;
                        case 5:
                            DeleteWord();
                            break;
                        case 6:
                            Console.WriteLine("Chương trình kết thúc.");
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số.");
                }

            } while (choice != 6);
            Console.ReadKey();
        }

        static void AddNewWord()
        {
            Console.Write("Nhập từ tiếng Anh: ");
            string englishWord = Console.ReadLine();

            if (dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine("Từ này đã tồn tại trong từ điển.");
            }
            else
            {
                Console.Write("Nhập từ tiếng Việt tương ứng: ");
                string vietnameseWord = Console.ReadLine();
                dictionary.Add(englishWord, vietnameseWord);
                Console.WriteLine("Thêm từ thành công.");
            }
        }

        static void DisplayAllWords()
        {
            Console.WriteLine("Danh sách các từ trong từ điển:");
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        static void SearchWord()
        {
            Console.Write("Nhập từ tiếng Anh cần tra: ");
            string englishWord = Console.ReadLine();

            if (dictionary.TryGetValue(englishWord, out string vietnameseWord))
            {
                Console.WriteLine($"Từ \"{englishWord}\" có nghĩa là \"{vietnameseWord}\".");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }

        static void EditWord()
        {
            Console.Write("Nhập từ tiếng Anh cần sửa: ");
            string englishWord = Console.ReadLine();

            if (dictionary.ContainsKey(englishWord))
            {
                Console.Write("Nhập từ tiếng Việt mới: ");
                string newVietnameseWord = Console.ReadLine();
                dictionary[englishWord] = newVietnameseWord;
                Console.WriteLine("Sửa từ thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }

        static void DeleteWord()
        {
            Console.Write("Nhập từ tiếng Anh cần xóa: ");
            string englishWord = Console.ReadLine();

            if (dictionary.ContainsKey(englishWord))
            {
                dictionary.Remove(englishWord);
                Console.WriteLine("Xóa từ thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }
    }
}
