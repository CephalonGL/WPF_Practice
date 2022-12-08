using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Model;

public class CustomString
{
    public string String { get; set; }

    public CustomString()
    {
        String = string.Empty;
    }

    public CustomString(string newString)
    {
        String = newString;
    }

    public bool IsPalindrome()
    {
        String.Replace(" ", "");
        string reversedString = String.Reverse().ToString();
        return String == reversedString;
    }
}
