using System;

public class TextInput
{

    public string value = "";
    public virtual void Add(char v)
    {
        value += v;
    }

    public string GetValue()
    {
        return this.value;
    }

    

}

public class NumericInput : TextInput{ 

   public override void Add(char v)
    {
        if (Char.IsDigit(v))
        {
            value += v;
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}