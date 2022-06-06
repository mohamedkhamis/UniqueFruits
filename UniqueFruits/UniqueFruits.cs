namespace UniqueFruits
{
    internal class UniqueFruits
    {

        public List<string>? EnumerableString { get; set; }
        public List<string> a1 { get; set;} 
        public List<string> a2 { get; set;} 

        internal UniqueFruits()
        {
            a1 =new List<string> { "Watermelon", "Apple", "Mango", "Guava", "Banana" };
            a2 =new List<string> { "Orange", "Kiwi", "Apple", "Watermelon" };
            EnumerableString = new List<string>();
            EnumerableString.AddRange(a1);
            EnumerableString.AddRange(a2);
        }
        public void UniqueFruitsLogicOne()
        {
            Console.WriteLine("First Method");
            Console.WriteLine("-----------------------");
            foreach (string? item in EnumerableString)
            { 
                if (!IsExist(item)) 
                { 
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("-----------------------");
        }
        public void UniqueFruitsLogicTwo()
        {
            Console.WriteLine("Second Method");
            Console.WriteLine("-----------------------");
            bool isExist;
            foreach (var item in a1)
            {
                isExist = false;
                foreach (var item2 in a2)
                {
                    if (item == item2)
                    {
                        isExist = true;
                        a2.Remove(item2);
                        break;
                    }
                }
                if(!isExist)
                    Console.WriteLine(item); 
            }
            foreach (var item2 in a2)
            {
                Console.WriteLine(item2);

            }
            Console.WriteLine("-----------------------");


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
