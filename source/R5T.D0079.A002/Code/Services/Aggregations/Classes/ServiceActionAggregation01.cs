using System;

using R5T.T0063;


namespace R5T.D0079.A002
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IVisualStudioProjectFileOperator> VisualStudioProjectFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioProjectFileOperatorExtension> VisualStudioProjectFileOperatorExtensionAction { get; set; }
    }
}
