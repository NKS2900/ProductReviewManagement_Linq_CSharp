using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReviewManagement_Linq_CSharp
{
    class ProductReviewManagement
    {
        public readonly DataTable dataTable = new DataTable();
        
        public void TopRecord ( List<ProductReview> listProductReview )
        {
            var recordData = (from productReview in listProductReview
                              orderby productReview.Rating descending
                              select productReview).Take(3).ToList();

            DisplayRecord(recordData);

        }
        public void SelectRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReview in listProductReview
                              where (productReview.ProductId == 1 || productReview.ProductId == 4 || productReview.ProductId == 9)
                              && productReview.Rating > 3
                              select productReview).ToList();

            DisplayRecord(recordData);
        }

        public void DisplayRecord(List<ProductReview> record)
        {
            foreach (var lists in record)
            {
                Console.WriteLine("Product id = " + lists.ProductId + " User id = " + lists.UserId + " Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.isLike);
            }
        }
    }
}
