using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.D0077; /// <see cref="R5T.D0077.Documentation"/>
using R5T.D0077.New; /// <see cref="R5T.D0077.New.Documentation"/>
using R5T.D0077.X001;using R5T.T0064; /// <see cref="R5T.D0077.X001.Documentation"/>


namespace R5T.D0079
{[ServiceImplementationMarker]
    public class VisualStudioProjectFileOperator : IVisualStudioProjectFileOperator,IServiceImplementation
    {
        private IDotnetOperator DotnetOperator { get; }


        public VisualStudioProjectFileOperator(
            IDotnetOperator dotnetOperator)
        {
            this.DotnetOperator = dotnetOperator;
        }

        public Task Create(string projectType, string projectName, string projectDirectoryPath)
        {
            return this.DotnetOperator.New(projectType, projectName, projectDirectoryPath);
        }

        public Task AddProjectReferences(string projectToModifyFilePath, IEnumerable<string> projectReferenceToAddFilePaths)
        {
            return this.DotnetOperator.AddProjectReferencesToProject(projectToModifyFilePath, projectReferenceToAddFilePaths);
        }

        public Task RemoveProjectReferenceIdempotent(string projectFilePathToModify, string projectReferenceFilePathToRemove)
        {
            return this.DotnetOperator.RemoveProjectReferenceFromProjectIdempotent(
                projectFilePathToModify,
                projectReferenceFilePathToRemove);
        }

        public Task<string[]> ListProjectReferenceRelativeFilePaths(string projectFilePath)
        {
            return this.DotnetOperator.ListProjectProjectReferenceRelativePaths(
                projectFilePath);
        }
    }
}
