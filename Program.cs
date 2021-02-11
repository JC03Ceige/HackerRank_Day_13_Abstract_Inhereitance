using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Day_13_Abstract_Inhereitance
{
    class Solution
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }

    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    //Write MyBook class
    class MyBook : Book
    {
        private int newPrice;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.newPrice = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title} \nAuthor: {author} \nPrice: {newPrice}");
            
        }
    }

}
