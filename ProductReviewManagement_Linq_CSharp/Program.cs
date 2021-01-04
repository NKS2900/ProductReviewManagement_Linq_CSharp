using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement_Linq_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_ProductReviewManagement***");
            List<ProductReview> list = new List<ProductReview>()
            {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review= "Good", isLike=true },
            new ProductReview() { ProductId = 1, UserId = 2, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 4, UserId = 4, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 5, UserId = 5, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 6, UserId = 12, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 7, UserId = 2, Rating = 2, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 8, UserId = 3, Rating = 1.5, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 9, UserId = 4, Rating = 3.5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 5, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 11, UserId = 6, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 12, UserId = 7, Rating = 3, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 12, UserId = 8, Rating = 1, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 14, UserId = 11, Rating = 2, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 15, UserId = 5, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 16, UserId = 6, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 17, UserId = 7, Rating = 3, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 18, UserId = 8, Rating = 1, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 19, UserId = 7, Rating = 2, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 20, UserId = 10, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 21, UserId = 5, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 22, UserId = 6, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 23, UserId = 12, Rating = 3, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 24, UserId = 8, Rating = 1, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 25, UserId = 9, Rating = 4, Review = "Good", isLike=true }
            };

            ProductReviewManagement productManagement = new ProductReviewManagement();
            productManagement.DisplayRecord(list);
            Console.WriteLine("***TOP_THREE_REVIEWS***");
            productManagement.TopRecord(list);
            Console.WriteLine("Select Record 1 , 4 , 9 Whos Rating > 3");
            productManagement.SelectRecords(list);
            Console.WriteLine("Count_of_Records_Using_GroupBy");
            productManagement.CountOfRectords(list);
            productManagement.RetrieveIdAndReview(list);
            Console.WriteLine("Skip_Top_Five_Records");
            productManagement.SkipTopFiveRecord(list);
            Console.WriteLine("***Data_Table***");
            DataTable data = productManagement.CreateTable(list);
            foreach (var table in list)
            {
                data.Rows.Add(table.ProductId, table.UserId, table.Rating, table.Review, table.isLike);
            }
            productManagement.RetrieveRecordsWithisLikeTrue(data);
            Console.WriteLine("Get_Average_Rating_Of_Product");
            productManagement.GetAvgRatings(list);
            Console.ReadKey();
        }
    }
}
