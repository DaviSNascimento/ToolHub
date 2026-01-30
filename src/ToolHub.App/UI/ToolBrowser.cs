using ToolHub.App.UI;
using Spectre.Console;
using ToolHub.App.Models;

namespace ToolHub.App.UI;

public class ToolBrowser
{
    public static void Show(List<ToolInfo> tools)
    {
        while (true)
        {
            AnsiConsole.Clear();

            AnsiConsole.Write(
                new FigletText("ToolHub")
                    .Centered()
                    .Color(Color.Blue1)
                );
                    
            AnsiConsole.MarkupLine("[yellow]Selecione uma Ferramenta[/]");
            AnsiConsole.WriteLine();

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<ToolInfo>()
                    .Title("[green]Ferramentas Disponíveis:[/]")
                    .PageSize(10)
                    .UseConverter(t => $"{t.Name} [grey]- {t.Category}[/]")
                    .AddChoices(tools)
            );

            ShowDetails(selection);

        }
    }
    
    private static void ShowDetails(ToolInfo tool)
    {
        AnsiConsole.Clear();

        var panel = new Panel(
            $"[bold]{tool.Name}[/]\n\n" +
            $"[yellow]Categoria:[/] {tool.Category}\n\n" +
            $"[yellow]Descrição:[/]\n{tool.Description}\n\n" +
            $"[yellow]Exemplo:[/]\n[green]{tool.Example}[/]\n\n" +
            $"[yellow]Ajuda:[/]\n{tool.Help}"
            )
        {
            Header = new PanelHeader("Detalhes da Ferramenta", Justify.Center),
            Border = BoxBorder.Rounded,
        };

        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();
        AnsiConsole.MarkupLine("[grey](Pressione qualquer tecla para voltar)[/]");

        Console.ReadKey(true);
    }


}

