namespace UniqueFruits
{
    internal class UniqueFruits
    {

        public List<string>? EnumerableString { get; set; }
        public void UniqueFruitsLogic()
        {
            string[] a1 = { "Watermelon", "Apple", "Mango", "Guava", "Banana" };
            string[] a2 = { "Orange", "Kiwi", "Apple", "Watermelon" };
            EnumerableString = new List<string>();
            EnumerableString.AddRange(a1);
            EnumerableString.AddRange(a2); 
            foreach (var item in EnumerableString) 
            { 
                if (!IsExist(item)) 
                { 
                    Console.WriteLine(item);
                }
            }
        }

        public bool IsExist( string fruitItem)
        {
            var counter = 0;
            if (EnumerableString == null) return false;
            foreach (var arrayItem in EnumerableString)
            {
                if (arrayItem != fruitItem) continue;
                counter++;
                if (counter > 1) break;
            }


            return counter > 1;
        }
    }
}
