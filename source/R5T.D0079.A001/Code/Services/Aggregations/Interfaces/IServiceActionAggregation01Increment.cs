using System;

using R5T.T0063;


namespace R5T.D0079.A001
{
    public interface IServiceActionAggregation01Increment
    {
        IServiceAction<IVisualStudioProjectFileOperator> VisualStudioProjectFileOperatorAction { get; set; }
        IServiceAction<IVisualStudioProjectFileOperatorExtension> VisualStudioProjectFileOperatorExtensionAction { get; set; }
    }
}
