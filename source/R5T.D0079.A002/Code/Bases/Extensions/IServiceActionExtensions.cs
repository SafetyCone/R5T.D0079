using System;

using R5T.Lombardy;

using R5T.D0077;
using R5T.T0062;
using R5T.T0063;

using R5T.D0079.Default;


namespace R5T.D0079.A002
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddVisualStudioProjectFileOperatorActions(this IServiceAction _,
            IServiceAction<IDotnetOperator> dotnetOperatorAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var visualStudioProjectFileOperatorAction = _.AddVisualStudioProjectFileOperatorAction(
                dotnetOperatorAction);

            var visualStudioProjectFileOperatorExtensionAction = _.AddVisualStudioProjectFileOperatorExtensionAction(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorAction);

            var output = new ServiceActionAggregation01
            {
                VisualStudioProjectFileOperatorAction = visualStudioProjectFileOperatorAction,
                VisualStudioProjectFileOperatorExtensionAction = visualStudioProjectFileOperatorExtensionAction,
            };

            return output;
        }
    }
}