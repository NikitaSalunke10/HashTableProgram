using HashTableProgram;

Console.WriteLine("Hash Table Program\n");
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "To");
hash.Add("1", "be");
hash.Add("2", "or");
hash.Add("3", "not");
hash.Add("4", "to");
hash.Add("5", "be");
string hash5 = hash.Get("5");
Console.WriteLine("5th index value: " + hash5);
string hash2 = hash.Get("2");
Console.WriteLine("2th index value: " + hash2);
string[] words = new string[6];
for (int i = 0; i < words.Length; i++)// for loop is used to store the hash values in string array
{
    string key = i.ToString();
    words[i] = hash.Get(key).ToLower(); // one by one the values are retrived and store at each key
}
hash.FindFrequency(words); //method is called to find the count of words