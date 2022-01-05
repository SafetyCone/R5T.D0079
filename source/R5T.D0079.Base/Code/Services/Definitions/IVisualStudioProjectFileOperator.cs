using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.D0079
{
    public interface IVisualStudioProjectFileOperator
    {
        Task AddProjectReferences(string projectToModifyFilePath, IEnumerable<string> projectReferenceToAddFilePaths);
        Task Create(string projectType, string projectName, string projectDirectoryPath);
        Task<string[]> ListProjectReferenceRelativeFilePaths(string projectFilePath);
        Task RemoveProjectReferenceIdempotent(string projectFilePathToModify, string projectReferenceFilePathToRemove);
    }
}
