namespace Lab29_Console_App
{
    public class Zoomarket
    {
        private List<string> products = new List<string>();

        public void AddProduct(string productName)
        {
            products.Add(productName);
        }

        public void UpdateProduct(string oldProductName, string newProductName)
        {
            if (products.Contains(oldProductName))
            {
                int index = products.IndexOf(oldProductName);
                products[index] = newProductName;
            }
            else
            {
                Console.WriteLine("Mehsul Tapilmadi!");
            }
        }

        public void DeleteProduct(string productName)
        {
            if (products.Contains(productName))
            {
                products.Remove(productName);
            }
            else
            {
                Console.WriteLine("Mehsul Tapilmadi!");
            }
        }
    }
}
