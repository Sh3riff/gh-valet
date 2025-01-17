using System.CommandLine;

namespace Valet.Commands.Circle;

public class Migrate : ContainerCommand
{
    public Migrate(string[] args) : base(args)
    {
    }

    protected override string Name => "circle-ci";
    protected override string Description => "Convert a CircleCI pipeline to GitHub Actions workflows and open a pull request with the changes.";

    protected override List<Option> Options => new()
    {
        Common.Organization,
        Common.Project,
        Common.Provider,
        Common.InstanceUrl,
        Common.AccessToken,
        Common.SourceGitHubAccessToken,
        Common.SourceGitHubInstanceUrl,
        Common.SourceFilePath,
    };
}