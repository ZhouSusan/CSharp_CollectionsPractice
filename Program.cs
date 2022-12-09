namespace CollectionsPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Three Basic Arrays\n");

            //Create an array to hold integer values 0 through 9
            int[] numbersArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] namesArr = { "Tim", "Martin", "Nikki", "Sara" };

            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArr = new bool[10];
            for (int i = 0; i < boolArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolArr[i] = true;
                } else
                {
                    boolArr[i] = false;
                }
            }

            Console.WriteLine("A print out with values 0 - 9:\n");
            PrintAllItems(numbersArr);

            Console.WriteLine("\nItems in Names Array:");
            foreach(var name in namesArr)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nBoolean Array:");
            foreach (var val in boolArr) {
                Console.WriteLine(val);
            }

            Console.WriteLine("\nMultipication Table");
            foreach(var row in GenerateMultipilcationTable())
            {
                System.Console.Write(row + " ");
            }


            Console.WriteLine("\nList of Flavor Ice Cream: ");
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Pistachos");
            iceCreamFlavors.Add("Cookies n' Cream");
            iceCreamFlavors.Add("Strawberry CheeseCake");
            iceCreamFlavors.Add("Twix Deluxe");
            iceCreamFlavors.Add("French Vanilla");
            iceCreamFlavors.Add("Snores");

            Console.WriteLine("Original Size of Ice Cream Flavor List: " + iceCreamFlavors.Count);
            Console.WriteLine("Third Ice Cream Flavor is " + iceCreamFlavors[2]);
            iceCreamFlavors.Remove(iceCreamFlavors[2]);
            Console.WriteLine("After removal- New List Size is: " + iceCreamFlavors.Count);

            Console.WriteLine("\nUser Info Dictionary: ");
            Dictionary<string, string> userInfoDict = new Dictionary<string, string>();

            //Set new key in the userFlavors dictonary with a name from the namesArr 
            foreach(string name in namesArr)
            {
                userInfoDict.Add(name, null);
                Console.WriteLine("Writing names: " + name);
            }

            //Random select an ice cream flavor from the list and store it as a value
            Random rand = new Random();
            List<string> userKeys = new List<string>(userInfoDict.Keys);
            for (int k = 0; k < userKeys.Count; k++)
            {
                userInfoDict[userKeys[k]] = iceCreamFlavors[rand.Next(0, 5)];
            }

            //Loop through Dictionary and print each out each key, value pair
            foreach(var entry in userInfoDict)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }

        static void PrintAllItems(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int [,] GenerateMultipilcationTable()
        {
            int[,] multiplicationTable = new int[10, 10];
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    multiplicationTable[row, col] = (row + 1) * (col + 1);
                }
            }

            return multiplicationTable;
        }
    }
}