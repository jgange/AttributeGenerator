namespace attributes;
public class Attributes
{
    private List<Attribute> _abilities = new List<Attribute>();

    public Attributes(List<Attribute> aList)
    {
        _abilities = aList;
    }

    public Attributes()
    {}

    public void Traverse()
    {
        foreach(Attribute attribute in _abilities)
        {
            Console.WriteLine(attribute);
        }
    }

}