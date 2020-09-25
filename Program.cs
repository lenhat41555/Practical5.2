using System;
using System.Collections.Generic;

namespace Practical5._2
{
    class Program
    {
        static void Main(string[] args)
        {
      Program pro = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.chen danh sach moi");
                Console.WriteLine("2.xem danh sach ");
                Console.WriteLine("3.gia trung binh ");
                Console.WriteLine("4.thoat ");
                Console.WriteLine("chon mot muc: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        pro.InsertBooks();
                        break;

                    case 2:
                        pro.ViewListBooks();
                        break;
                    case 3:
                        pro.AveragePrice();
                        break;
                    case 4:
                        return;
                        
                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListBook = new Dictionary<int, object>();
        public void InsertBooks(){
            Book b = new Book();
            b.ID = count;
            Console.WriteLine("Name : ");
            b.Name = Console.ReadLine();
            Console.WriteLine("Publish Date :");
            b.PublishDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Author :");
            b.Author = Console.ReadLine();
            Console.WriteLine("Language :");
            b.Language = Console.ReadLine();            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Average Price " + (i + 1) + ":");
                b[i] = int.Parse(Console.ReadLine());

            }
            ListBook.Add(count, b);
            count++;

        }

        public void ViewListBooks()
        {
            foreach (Book item in ListBook.Values)
            {
                item.Display();
            }
        }
        public void AveragePrice()
        {
            foreach (Book item in ListBook.Values)
            {
                item.Display();
                item.Calculate();
            }
        }
    }
}

