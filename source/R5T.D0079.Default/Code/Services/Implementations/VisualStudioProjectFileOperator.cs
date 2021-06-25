using System;
using System.Threading.Tasks;

using R5T.D0077; /// <see cref="R5T.D0077.Documentation"/>
using R5T.D0077.New; /// <see cref="R5T.D0077.New.Documentation"/>
using R5T.D0077.X001; /// <see cref="R5T.D0077.X001.Documentation"/>


namespace R5T.D0079
{
    public class VisualStudioProjectFileOperator : IVisualStudioProjectFileOperator
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

        public Task AddProjectReference(string projectToModifyFilePath, string projectReferenceToAddFilePath)
        {
            return this.DotnetOperator.AddProjectReferenceToProject(projectToModifyFilePath, projectReferenceToAddFilePath);
        }
    }
}
