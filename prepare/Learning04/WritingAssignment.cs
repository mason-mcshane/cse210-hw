public class WritingAssignment : Assignment
{
    private string _title;

    // The WritingAssignment constructor has 3 parameters, then passes 2 of them
    // directly to the "base" constructor, with is the "Assignment" class constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
        {
            // This is where we set the WritingAssignment class variables
            _title = title;
        }

        public string GetWritingInformation()
        {
            string studentName = GetStudentName();

            return $"{_title} by {studentName}";
        }
}