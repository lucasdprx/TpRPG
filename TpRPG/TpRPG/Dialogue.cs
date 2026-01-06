namespace TpRPG;

public class Dialogue
{
    private List<string> lines;
    private int currentLineIndex;
    
    public Dialogue(List<string> lines)
    {
        this.lines = lines;
        currentLineIndex = 0;
    }
    public string? GetCurrentLine()
    {
        return currentLineIndex < lines.Count ? lines[currentLineIndex] : null;
    }
    public bool MoveNext()
    {
        if (currentLineIndex < lines.Count - 1)
        {
            currentLineIndex++;
            return true;
        }
        return false;
    }
}