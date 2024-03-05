using System.Text.Json;
class Program
{
    static void Main()
    {
        Dictionary<string, int> x = new Dictionary<string, int>();
        Dictionary<string, int> y = new Dictionary<string, int>();
        x.Add("key1", 1);
        x.Add("key2", 3);
        x.Add("key3", 2);
        //x["key4"] = 49;


        y.Add("key1", 1);
        y.Add("key2", 2);
        //y["key5"] = 409;

        Console.WriteLine("Перший словник:");
        foreach (var k in x)
        {
            Console.WriteLine(k.Key + " " + k.Value);
        }
        Console.WriteLine("--------");

        Console.WriteLine("Другий словник");
        foreach (var k in y)
        {
            Console.WriteLine(k.Key + " " + k.Value);
        }
        Console.WriteLine("--------");

        string key1, key2;
        foreach (var k1 in x)
        {
            key1 = k1.Key;
            foreach (var k2 in y)
            {
                key2 = k2.Key;
                if (key1 == key2 && k1.Value == k2.Value)
                {
                    Console.WriteLine($"{key1}:{k1.Value} is present in both x and y ");
                }
            }
        }
        //Dictionary<string, int> xy = new Dictionary<string, int>();
        //foreach (var k1 in x)
        //{
        //    foreach (var k2 in y)
        //    {
        //        if (k1.Key == k2.Key && k1.Value == k2.Value)
        //        {
        //            xy[k1.Key] = k2.Value;
        //        }
        //    }
        //}
        //string js = JsonSerializer.Serialize(xy);
        //Console.WriteLine(js + "is present in both x and y");
    }
}