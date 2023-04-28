using System.Collections.Generic;
using System.Linq;

public class DeveloperConsole
{  
    private readonly IEnumerable<IConsoleCommands> commands;

    public DeveloperConsole(IEnumerable<IConsoleCommands> commands) {
        this.commands = commands;
    }

    public void handleCommand(string inputValue) {
        string[] inputSplit = inputValue.Split(" ");
        string commandInput = inputSplit[0];

        string[] args = inputSplit.Skip(1).ToArray();
        this.handleCommand(commandInput, args);
    }

    public void handleCommand(string commandInput, string[] args) {
        foreach (var command in this.commands) {
            if (!commandInput.Equals(command.commandWord, System.StringComparison.OrdinalIgnoreCase)) {
                continue;
            }

            if (command.handle(args)) {
                return;
            }
        }
    }
}
