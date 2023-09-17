using Spectre.Console;
using Spectre.Console.Cli;

namespace AzureCostCli.Commands.ShowCommand;

public class VersionCommand : AsyncCommand<VersionSettings>
{
    public override Task<int> ExecuteAsync(CommandContext context, VersionSettings settings)
    {
      AnsiConsole.WriteLine($"Version: {typeof(VersionCommand).Assembly.GetName().Version}");
      return Task.FromResult(0);
    }
}