using System.CommandLine;

namespace Valet.Commands.Travis;

public class Forecast : ContainerCommand
{
    public Forecast(string[] args) : base(args)
    {
    }

    protected override string Name => "travis-ci";
    protected override string Description => "Forecasts GitHub Actions usage from historical Travis CI pipeline utilization.";

    public static readonly Option<FileInfo[]> SourceFilePath = new("--source-file-path")
    {
        Description = "The file path(s) to existing jobs data.",
        IsRequired = false,
        AllowMultipleArgumentsPerToken = true,
    };

    protected override List<Option> Options => new()
    {
        Common.Organization,
        Common.InstanceUrl,
        Common.AccessToken,
        SourceFilePath
    };
}
