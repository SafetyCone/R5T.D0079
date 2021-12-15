using System;

using R5T.D0074;
using R5T.D0077;
using R5T.D0078;
using R5T.T0063;


namespace R5T.D0079.A001
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IVisualStudioProjectFileOperator> VisualStudioProjectFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioProjectFileOperatorExtension> VisualStudioProjectFileOperatorExtensionAction { get; set; }
        public IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        public IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
        public IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        public IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
        public IServiceAction<D0075.ICommandLineOperator> BaseCommandLineOperatorAction { get; set; }
        public IServiceAction<D0076.ICommandLineOperator> CommandLineOperatorAction { get; set; }
        public IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
