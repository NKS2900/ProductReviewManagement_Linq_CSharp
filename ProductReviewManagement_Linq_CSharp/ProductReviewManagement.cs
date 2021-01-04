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
                              select productReview).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product id = " + list.ProductId + " User id = " + list.UserId + " Rating is = " + list.Rating + " Review is = " + list.Review + " isLike = " + list.isLike);
            }
        }
    }
}
