using System;
using System.Threading.Tasks;

using R5T.T0029.Dotnet.T001; /// <see cref="R5T.T0029.Dotnet.T001.Documentation"/>


namespace R5T.D0079
{
    public static class IVisualStudioProjectFileOperatorExtensions
    {
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
