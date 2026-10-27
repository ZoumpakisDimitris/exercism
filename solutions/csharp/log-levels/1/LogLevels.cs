static class LogLine
{
    public static string Message(string logLine)
    {
        //find where the colon seperator is
        int colon = logLine.IndexOf(": "); 
        // grab everything after it - Substring(start)
        string rest = logLine.Substring(colon + 2);
        //trim off the trailing whitespace
        return rest.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int closingBracket = logLine.IndexOf(']');
        string level = logLine.Substring(1, closingBracket - 1); // where the cut is made
        return level.ToLower(); //from uppercase to lowercase
    }

    public static string Reformat(string logLine)
    {
        //re-using methods instead of re-cutting 
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";
    }
}
