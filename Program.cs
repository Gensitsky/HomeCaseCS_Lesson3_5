/*
    Описать перечисление ArticleType определяющее
    типы товаров, и добавить соответствующее поле
    в структуру Article из задания №1.
*/
using System;

namespace HomeCaseCS_Lesson3_5
{
    enum ArticleType
    {
        Electronics,
        Computers,
        Printers,
        Office
    }
    struct Article
    {
        private int productId;
        private string productName;
        private double productPrice;
        private ArticleType productType;

        public Article(int pId, string pName, double pPrice,
            ArticleType pType)
        {
            productId = pId;
            productName = pName;
            productPrice = pPrice;
            productType = pType;
        }
        public void PrintArticle()
        {
            Console.WriteLine($"Code:\t{productId}");
            Console.WriteLine($"Type:\t{productType}");
            Console.WriteLine($"Name:\t{productName}");
            Console.WriteLine($"Price:\t{productPrice} $\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article(1, "Notebook Asus X751LB", 700,
                ArticleType.Computers);
            Article article2 = new Article(2, "Printer Xerox WC3119", 200,
                ArticleType.Printers);
            Article article3 = new Article(3, "TV Samsung 40", 1000,
                ArticleType.Electronics);

            article1.PrintArticle();
            article2.PrintArticle();
            article3.PrintArticle();

            Console.ReadKey();
        }
    }
}
