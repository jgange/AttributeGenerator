namespace attributes;
﻿using System.Text.Json;

public class SerializeList
{
    private readonly List<Attribute> _attributeList;
    private readonly JsonSerializerOptions _options = new() 
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
        };

    public SerializeList(List<Attribute> AttributeList)
    {
        _attributeList = AttributeList;
    }

    public string SerializeMethod()
    {
        return JsonSerializer.Serialize(_attributeList, _options);
    }
    
    public void WriteSerializedObject(string fileName, string serializedObject)
    {
        File.WriteAllText(fileName, serializedObject);
    }
}