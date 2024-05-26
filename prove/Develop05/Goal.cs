using System;

public abstract class Goal
{ 
    private string _shortName;
    private string _description;
    private int _points;
 
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string ShortName
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
 
    public virtual string GetDetailsString() 
    {
        if(IsComplete())
        {
        return $"[X] {_shortName} {_description}";
        }
        else
        {
            return $"[ ] {_shortName} {_description}";
        }
    }
    public abstract string GetStringRepresentation();
}