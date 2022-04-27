using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0032;using R5T.T0064;


namespace R5T.D0079.Default
{[ServiceImplementationMarker]
    public class VisualStudioProjectFileOperatorExtension : IVisualStudioProjectFileOperatorExtension,IServiceImplementation
    {
        private IFileNameOperator FileNameOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
        private IVisualStudioProjectFileOperator VisualStudioProjectFileOperator { get; }


        public VisualStudioProjectFileOperatorExtension(
            IFileNameOperator fileNameOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            IVisualStudioProjectFileOperator visualStudioProjectFileOperator)
        {
            this.FileNameOperator = fileNameOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.VisualStudioProjectFileOperator = visualStudioProjectFileOperator;
        }

        public Task Create(string projectType, string projectFilePath)
        {
            var projectName = this.StringlyTypedPathOperator.GetFileNameWithoutExtension(projectFilePath);

            var projectDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPathForFilePath(projectFilePath);

            return this.VisualStudioProjectFileOperator.Create(projectType, projectName, projectDirectoryPath);
        }

        public Task<string> GetProjectFilePath(string projectDirectoryPath, string projectName)
        {
            // Assume that the project name is a valid project file name stem.
            var projectFileNameStem = projectName;

            var projectFileName = this.FileNameOperator.GetFileName(projectFileNameStem, FileExtension.Instance.CSharpProject());

            var projectFilePath = this.StringlyTypedPathOperator.GetFilePath(projectDirectoryPath, projectFileName);

            return Task.FromResult(projectFilePath);
        }
    }
}
