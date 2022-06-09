using System;

using R5T.Magyar;

using R5T.D0079;

using Instances = R5T.D0079.Instances;


namespace System
{
    public static class VisualStudioProjectTypeExtensions
    {
        public static string ToString_ForProjectFileOperator(this VisualStudioProjectType projectType)
        {
            return projectType switch
            {
                VisualStudioProjectType.ClassLibrary => Instances.DotnetNewTemplate.ClassLib(),
                VisualStudioProjectType.Console => Instances.DotnetNewTemplate.Console(),
                _ => throw EnumerationHelper.SwitchDefaultCaseException(projectType),
            };
        }
    }
}
