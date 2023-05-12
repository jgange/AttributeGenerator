namespace attributes;
﻿using System.Text.Json;

public class DeserializeList
{
    // takes a non-null string for a filepath for the file to deserialize
    // returns an object of the Attribute    
    public DeserializeList(string fileName)
    {
        if (fileName != null)
        {
            string _jsonString = File.ReadAllText(fileName);
            Console.WriteLine(_jsonString);
            Attributes? aList = JsonSerializer.Deserialize<Attributes>(_jsonString);
        }
    }
}