using System;

using R5T.Dacia;


namespace R5T.D0079.A001
{
    public class ServicesAggregation01 : D0078.A001.ServicesAggregation01,
        IServicesAggregation01
    {
        public IServiceAction<IVisualStudioProjectFileOperator> VisualStudioProjectFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioProjectFileOperatorExtension> VisualStudioProjectFileOperatorExtensionAction { get; set; }
    }
}
