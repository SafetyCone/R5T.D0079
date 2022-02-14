using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0079
{
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileOperator : IServiceDefinition
    {
        Task AddProjectReferences(string projectToModifyFilePath, IEnumerable<string> projectReferenceToAddFilePaths);
        Task Create(string projectType, string projectName, string projectDirectoryPath);
        Task<string[]> ListProjectReferenceRelativeFilePaths(string projectFilePath);
        Task RemoveProjectReferenceIdempotent(string projectFilePathToModify, string projectReferenceFilePathToRemove);
    }
}
