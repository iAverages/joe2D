using UnityEngine;

[CreateAssetMenu(fileName = "New Log Command", menuName = "Utilities/DeveloperConsole/Commands/Log Command")]
public class LogCommnad : ConsoleCommand {

    public override bool handle(string[] args)
    {
        Debug.Log(string.Join(" ", args));
        return true;
    }
}