using HashTableProgram;

Console.WriteLine("Hash Table Program");
MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
hash.Add("0", "Paranoids");
hash.Add("1", "are");
hash.Add("2", "not");
hash.Add("3", "paranoid");
hash.Add("4", "because");
hash.Add("5", "they");
hash.Add("6", "are");
hash.Add("7", "paranoid");
hash.Add("8", "but");
hash.Add("9", "because");
hash.Add("10", "they");
hash.Add("11", "keep");
hash.Add("12", "putting");
hash.Add("13", "themselves");
hash.Add("14", "deliberately");
hash.Add("15", "into");
hash.Add("16", "paranoid");
hash.Add("17", "avoidable");
hash.Add("18", "situations");

hash.Remove("17");
Console.WriteLine("\nWord is removed.");

//string[] words = new string[18];
//for (int i = 0; i < words.Length; i++)// for loop is used to store the hash values in string array
//{
//    string key = i.ToString();
//    words[i] = hash.Get(key).ToLower(); // one by one the values are retrived and store at each key
//}
//hash.FindFrequency(words); //method is called to find the count of words