using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.D0079;

using R5T.T0029.Dotnet.T001; /// <see cref="R5T.T0029.Dotnet.T001.Documentation"/>


namespace System
{
    public static class IVisualStudioProjectFileOperatorExtensions
    {
        public static async Task AddProjectReference(this IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            string projectToModifyFilePath, string projectReferenceToAddFilePath)
        {
            await visualStudioProjectFileOperator.AddProjectReferences(
                projectToModifyFilePath,
                EnumerableHelper.From(projectReferenceToAddFilePath));
        }

        public static Task AddProjectReferenceOkIfAlreadyAdded(this IVisualStudioProjectFileOperator visualStudioProjectFileOperator, 
            string projectToModifyFilePath, string projectReferenceToAddFilePath)
        {
            // TODO, assumes that service is ok if this happens. Should test if exists, and only if not, call.
            return visualStudioProjectFileOperator.AddProjectReference(projectToModifyFilePath, projectReferenceToAddFilePath);
        }

        public static Task AddProjectReferencesOkIfAlreadyAdded(this IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            string projectToModifyFilePath, IEnumerable<string> projectReferenceToAddFilePaths)
        {
            // TODO, assumes that service is ok if this happens. Should test if exists, and only if not, call.
            return visualStudioProjectFileOperator.AddProjectReferences(projectToModifyFilePath, projectReferenceToAddFilePaths);
        }

        public static async Task Create(this IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            string projectName,
            string projectDirectoryPath,
            VisualStudioProjectType projectType)
        {
            switch (projectType)
            {
                case VisualStudioProjectType.ClassLibrary:
                    await visualStudioProjectFileOperator.CreateLibrary(
                        projectName,
                        projectDirectoryPath);
                    break;

                case VisualStudioProjectType.Console:
                    await visualStudioProjectFileOperator.CreateConsole(
                        projectName,
                        projectDirectoryPath);
                    break;

                default:
                    throw EnumerationHelper.SwitchDefaultCaseException(projectType);
            }
        }

        public static Task CreateConsole(this IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            string projectName,
            string projectDirectoryPath)
        {
            return visualStudioProjectFileOperator.Create(DotnetNewTemplate.Instance.Console(), projectName, projectDirectoryPath);
        }

        public static Task CreateLibrary(this IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            string projectName,
            string projectDirectoryPath)
        {
            return visualStudioProjectFileOperator.Create(DotnetNewTemplate.Instance.ClassLib(), projectName, projectDirectoryPath);
        }
    }
}
