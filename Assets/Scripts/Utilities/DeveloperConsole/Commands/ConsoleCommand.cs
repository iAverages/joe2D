using UnityEngine;

public abstract class ConsoleCommand : ScriptableObject, IConsoleCommands
{
    [SerializeField] private string _commandWord = string.Empty;
    public string commandWord => _commandWord;

    public abstract bool handle(string[] args);
}
