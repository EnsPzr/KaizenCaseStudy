using System.Text;

namespace CodeGenerator;
public static class CodeGenerator
{
    /// <summary>
    /// This function assigns an int value to each value in the character string. A dictionary returns.
    /// </summary>
    /// <returns>
    /// 0:A
    /// 1:C
    /// 2:2
    /// 3:3
    /// 4:4
    /// 5:5
    /// 6:D
    /// 7:7
    /// 8:E
    /// ...
    /// </returns>
    private static Dictionary<int, string> GenerateNumberCodes()
    {
        //characters are separated into array for easy manipulation
        var charSet = "ACDEFGHKLMNPRTXYZ234579".ToCharArray().Select(d => d.ToString()).ToList();
        var charAndValueDictionary = new Dictionary<int, string>();
        var startValue = 0;
        while (charSet.Count > 0)
        {
            //if the next number value to be assigned is in our character array, it directly throws it.
            //otherwise it throws a string of numbers to the next character
            var isExistNumber = charSet.Any(d => d.Equals(startValue.ToString()));
            if (isExistNumber)
            {
                charAndValueDictionary.Add(startValue, startValue.ToString());
                charSet.Remove(startValue.ToString());
            }
            else
            {
                charAndValueDictionary.Add(startValue, charSet.First());
                charSet.Remove(charSet.First());
            }

            startValue += 1;
        }


        return charAndValueDictionary;
    }

    /// <summary>
    /// This function randomly generates a unique code value.
    /// It calculates the last 2 digits using the first 6 digits of the generated code.
    /// The last 2 digits it calculates are used as security.
    /// </summary>
    /// <returns>
    ///"3KN597DX"
    ///"27K5HLAR"
    ///"4FME5P2N"
    /// </returns>
    public static string GenerateCode()
    {
        //get unix time
        var unixTime = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();

        var rnd = new Random(Guid.NewGuid().GetHashCode() + DateTime.Now.Millisecond + DateTime.Now.Microsecond);
        //add random value
        for (var i = 0; i < 10; i++)
        {
            var val = rnd.NextInt64(0, 999999999);
            unixTime += val;
        }

        //unix time converting to int array for easy handling
        var unixTimeArray = unixTime.ToString().Select(t => int.Parse(t.ToString())).Reverse().ToArray();
        var code = new StringBuilder();

        //get character codes
        var charAndNumber = GenerateNumberCodes();

        var maxValue = charAndNumber.Keys.Max();
        //create the first part of the code
        //the first six characters of the code part and the last 2 characters
        //first six characters are created here
        var keys = new List<int>()
        {
            (unixTimeArray[0] * rnd.Next(100,1000) + unixTimeArray[12] * 1000) % maxValue,
            (unixTimeArray[1] * rnd.Next(100,1000) + unixTimeArray[11] * rnd.Next(100,1000)) % maxValue,
            (unixTimeArray[2] * rnd.Next(100,1000) + unixTimeArray[10] * rnd.Next(100,1000)) % maxValue,
            (unixTimeArray[3] * rnd.Next(100,1000) + unixTimeArray[9] * rnd.Next(100,1000)) % maxValue,
            (unixTimeArray[4] * rnd.Next(100,1000) + unixTimeArray[8] * rnd.Next(100,1000)) % maxValue,
            (unixTimeArray[5] * rnd.Next(100,1000) + unixTimeArray[7] * rnd.Next(100,1000)) % maxValue
        };
        //letters or numbers of values are written as strings
        code.Append(charAndNumber[keys[0]]);
        code.Append(charAndNumber[keys[1]]);
        code.Append(charAndNumber[keys[2]]);
        code.Append(charAndNumber[keys[3]]);
        code.Append(charAndNumber[keys[4]]);
        code.Append(charAndNumber[keys[5]]);

        //calculating the last 2 characters to be used for security
        var securityKeys = new List<int>()
        {
            (keys.Take(3).Sum() * 500) % maxValue,
            (keys.Skip(3).Take(3).Sum() * 200) % maxValue,
        };
        //string equivalents of calculated security values are written to the code
        code.Append(charAndNumber[securityKeys[0]]);
        code.Append(charAndNumber[securityKeys[1]]);

        return code.ToString();
    }


    /// <summary>
    /// This function provides control of an incoming code.
    /// First, it checks if the code is empty. It then checks whether the code length is as long as we want.
    /// Finally, it calculates the security code using the first 6 digits of the code.
    /// It checks its accuracy by comparing it with the last 2 digits of the incoming code.
    /// </summary>
    /// <param name="code"></param>
    /// <returns>bool value</returns>
    public static bool CheckCode(string code)
    {
        //null checking
        if (string.IsNullOrEmpty(code))
            return false;

        //length checking
        if (code.Length != 8)
            return false;

        //code is split into characters for easy processing
        var charSet = code.ToCharArray().Select(d => d.ToString()).ToList();

        //get character codes
        var charAndNumber = GenerateNumberCodes();
        var maxValue = charAndNumber.Keys.Max();
        var values = new List<int>();
        foreach (var character in charSet)
        {
            //checking if the character is a valid character
            if (!charAndNumber.ContainsValue(character))
                return false;
            //the numeric equivalent of the character is found and added to the array
            var value = charAndNumber.FirstOrDefault(d => d.Value.Equals(character)).Key;
            values.Add(value);
        }

        //calculating the security value of the incoming code
        var calculatedSecurityValues = new List<int>()
        {
            (values.Take(3).Sum() * 500) % maxValue,
            (values.Skip(3).Take(3).Sum() * 200) % maxValue,
        };
        //security codes in the code are parsed
        var securityValues = new List<int>()
        {
            values[6],
            values[7]
        };

        //it is checked whether the security code in the incoming code and the calculated security code are the same.
        return calculatedSecurityValues[0] == securityValues[0] && calculatedSecurityValues[1] == securityValues[1];
    }
}