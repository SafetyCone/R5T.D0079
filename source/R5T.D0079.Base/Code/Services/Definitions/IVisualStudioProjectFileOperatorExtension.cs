using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0079
{
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileOperatorExtension : IServiceDefinition
    {
        Task Create(string projectType, string projectFilePath);

        Task<string> GetProjectFilePath(string projectDirectoryPath, string projectName);
    }
}
