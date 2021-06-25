using System;

using R5T.Dacia;


namespace R5T.D0079.A001
{
    public interface IServicesAggregation01Increment
    {
        IServiceAction<IVisualStudioProjectFileOperator> VisualStudioProjectFileOperatorAction { get; set; }
        IServiceAction<IVisualStudioProjectFileOperatorExtension> VisualStudioProjectFileOperatorExtensionAction { get; set; }
    }
}
