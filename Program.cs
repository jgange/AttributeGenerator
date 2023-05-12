// create the list of attributes here
// create the object in another file
using System;

namespace attributes{
    static class program
    {
        static void Main()
        {

            string fileName = @".\attributes.json";

            List<Attribute> abilities = new List<Attribute>()
            {
                new Attribute("Strength",34),
                new Attribute("Dexterity",55),
                new Attribute("Constitution",44)
            };

            Attributes aList = new Attributes(abilities);

            aList.Traverse();

            SerializeList abilitiesSerialized = new SerializeList(abilities);
            //Console.WriteLine(abilitiesSerialized.SerializeMethod());

            abilitiesSerialized.WriteSerializedObject(fileName, abilitiesSerialized.SerializeMethod());

            DeserializeList dlist = new DeserializeList(fileName);

        }
    }
}