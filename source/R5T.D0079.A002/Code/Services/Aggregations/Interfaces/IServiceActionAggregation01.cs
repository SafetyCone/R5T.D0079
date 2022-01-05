using System;

using R5T.T0063;


namespace R5T.D0079.A002
{
    public interface IServiceActionAggregation01
    {
        IServiceAction<IVisualStudioProjectFileOperator> VisualStudioProjectFileOperatorAction { get; set; }
        IServiceAction<IVisualStudioProjectFileOperatorExtension> VisualStudioProjectFileOperatorExtensionAction { get; set; }
    }
}
