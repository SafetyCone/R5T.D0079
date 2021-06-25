using System;
using System.Threading.Tasks;


namespace R5T.D0079
{
    public interface IVisualStudioProjectFileOperatorExtension
    {
        Task Create(string projectType, string projectFilePath);

        Task<string> GetProjectFilePath(string projectDirectoryPath, string projectName);
    }
}
