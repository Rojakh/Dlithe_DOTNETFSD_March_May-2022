using System;
using System.Collections;
public class Program
{
	public static void Main() { 
	IDictionary<int, string> numberNames = new Dictionary<int, string>();
	numberNames.Add(1,"One"); //adding key/value using the Add() method
		numberNames.Add(3, "Three");
		numberNames.Add(2,"Two");
		
		foreach(KeyValuePair<int, string> kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		//creating a dictionary using collection-initializer syntax
		var cities = new Dictionary<string, string>(){
			{"1","London, Manchester, Birmingham"},
			{"2","Chicago, New York, Washington"},
			{"3","Mumbai, New Delhi, Pune"}
		};
		
		foreach(var kvp in cities)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

	}
}
