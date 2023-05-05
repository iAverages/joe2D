using UnityEngine;

public interface IConsoleCommands 
{
    string commandWord { get; }
    bool handle(string[] args);
}
