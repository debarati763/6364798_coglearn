using System;

namespace ECommerceSearch
{
    public class SearchAlgorithms
    {
        public static Product LinearSearch(Product[] products, string nameToFind)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(nameToFind, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        public static Product BinarySearch(Product[] sortedProducts, string nameToFind)
        {
            int left = 0;
            int right = sortedProducts.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(sortedProducts[mid].ProductName, nameToFind, true);

                if (comparison == 0)
                    return sortedProducts[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
