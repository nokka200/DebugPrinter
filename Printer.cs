namespace DebugPrinter;

static public class DebugInfo
{


    /// <summary>
    /// Returns time and functions name to be called
    /// </summary>
    /// <param name="funcToCall">Functions name</param> z
    /// <returns>Formated string</returns>
    public static string DebugPrintFuncCall(string funcToCall)
    {
        var dateObj = DateTime.Now;
        string strObj = new($"{dateObj} Calling {funcToCall}");
        return strObj;
    }

    /// <summary>
    /// Returns and prints the time and function name to be called.
    /// </summary>
    /// <param name="funcToCall">Functions name</param>
    /// <param name="toPrint">Enable Console text</param>
    /// <returns>Formated string</returns>
    public static string DebugPrintFuncCall(string funcToCall, bool toPrint)
    {
        string temp = DebugPrintFuncCall(funcToCall);
        if (toPrint)
        {
            PrintWithColor(temp);
        }

        return temp;
    }

    /// <summary>
    /// Prints variable with time
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="variableToPrint">Variables value</param>
    /// <param name="variableName">Variables name</param>
    public static void DebugPrintVari<T>(T variableToPrint, string variableName)
    {
        var dateObj = DateTime.Now;
        string strObj = new($"{dateObj}: {variableName}: {variableToPrint}");

        PrintWithColor(strObj);
    }

    /// <summary>
    /// Prints a collection with time
    /// </summary>
    /// <typeparam name="T">List's type</typeparam>
    /// <param name="itemToLoop">List to print</param>
    /// <param name="listName">List variables name</param>
    public static void DebugPrintCollection<T>(List<T> itemToLoop, string listName)
    {
        var dateObj = DateTime.Now;
        Console.WriteLine($"{dateObj}: {listName} :");

        foreach (var item in itemToLoop)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Sets foreground color to red prints value and sets foreground to before red color
    /// </summary>
    /// <param name="value">To print</param>
    private static void PrintWithColor(string value)
    {
        ConsoleColor tempF = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(value);
        Console.ForegroundColor = tempF;
    }
}
