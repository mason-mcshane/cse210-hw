public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // MathAssignment constructor has 4 parameters and then will pass 2
    // of them to the base constructor (which is the "Assignment" class constructor).
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
            // This is where we set the MathAssignment specific variables
            _textbookSection = textbookSection;
            _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}