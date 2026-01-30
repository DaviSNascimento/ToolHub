using ToolHub.App.Models;
using ToolHub.App.UI;

var tools = new List<ToolInfo>
{
    new ToolInfo
    {
        Name = "ls",
        Category = "Files",
        Description = "Lista arquivos e diretórios",
        Example = "ls -la",
        Help = "man ls"
    },
    new ToolInfo
    {
        Name = "grep",
        Category = "Text",
        Description = "Busca padrões em arquivos de texto",
        Example = "grep ERROR app.log",
        Help = "man grep"
    },
    new ToolInfo
    {
        Name = "curl",
        Category = "Network",
        Description = "Faz requisições HTTP e testa APIs",
        Example = "curl https://example.com",
        Help = "man curl"
    }
};

ToolBrowser.Show(tools);
