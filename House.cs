using System;
using System.Collections.Generic;
using task_1;

public class House
{
    bool isLocked;
    System.Collections.Generic.List<task_1.Window> windows = new List<task_1.Window>();
    System.Collections.Generic.List<task_1.Door> doors = new List<task_1.Door>();
    public House()
    {
        windows.Add(new task_1.Window());
        windows.Add(new task_1.Window());
        windows.Add(new task_1.Window());
        windows.Add(new task_1.Window());
        doors.Add(new task_1.Door());
        doors.Add(new task_1.Door());
    }

    public void Lock()
    {
        Console.WriteLine("Do you want to lock the door?");
        string input = Console.ReadLine();
        if (input == "yes")
        {
            isLocked = true;
            Console.WriteLine("The door is locked now.");
        }
        else
        {
            isLocked = false;
            Console.WriteLine("The door is opened now.");
        }

    }
    public void Amount()
    {
        Console.WriteLine("number of windows : " + this.windows.Count);
        Console.WriteLine("number of doors : " + this.doors.Count);

    }

    public override bool Equals(object obj)
    {

        bool equals = obj is House house &&
               isLocked == house.isLocked &&
               EqualityComparer<List<Window>>.Default.Equals(windows, house.windows) &&
               EqualityComparer<List<Door>>.Default.Equals(doors, house.doors);
        Console.WriteLine(equals);

        return equals;

    }

    public override int GetHashCode()
    {
        int hashCode = HashCode.Combine(isLocked, windows, doors);
        Console.WriteLine(hashCode);
        return hashCode;

    }

    public override string ToString()
    {

        Console.WriteLine("isLocked:" + isLocked);
        Console.WriteLine("doors:" + doors.Count);
        Console.WriteLine("windows:" + windows.Count);
        return base.ToString();
    }
}
