using System;
using System.Threading.Tasks;


namespace R5T.D0079
{
    public interface IVisualStudioProjectFileOperator
    {
        Task AddProjectReference(string projectToModifyFilePath, string projectReferenceToAddFilePath);
        Task Create(string projectType, string projectName, string projectDirectoryPath);
    }
}
