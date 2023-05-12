// three fields- Attribute Name, Attribute Raw Value, Attribute Tier
// where tier is calculated by dividing the Raw Value by 10 and rounding down

namespace attributes;
public class Attribute
{
    public string AttributeName {get; set;} = "";
    public int    AttributeRawValue {get; set;} = 0;
    public int    AttributeTierValue {get; set;} = 0;

    public Attribute(string name, int Raw)
    {
        AttributeName = name;
        AttributeRawValue = Raw;
        CalculateTierValue(AttributeRawValue);
    }

    private void CalculateTierValue(int rawvalue)
    {
        AttributeTierValue = rawvalue/10;
    }

    public override string ToString()
    {
        return AttributeName + ": " + AttributeTierValue + " -- Raw Value= " + AttributeRawValue;
    }

}