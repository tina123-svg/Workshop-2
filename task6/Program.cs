List<string> fruits = new List<string> { "Orange", "Apple", "Banana" };

fruits.Add("Mango");
fruits.Remove("Orange");

Console.WriteLine("Fruits List: ");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDict = new Dictionary<int, string> { { 1, "Apple" }, { 2, "Banana" }, { 3, "Mango" } };
fruitDict.Add(4, "Grapes");

Console.WriteLine("Fruit Dictionary: ");
foreach (KeyValuePair<int, string> item in fruitDict)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
