using System;

using Microsoft.Extensions.Configuration;

using R5T.Lombardy;
using R5T.Magyar.Extensions;

using R5T.D0078.A001;
using R5T.T0062;
using R5T.T0063;

using R5T.D0079.Default;


namespace R5T.D0079.A001
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddVisualStudioSolutionAndProjectOperatorServiceActions(this IServiceAction _,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var visualStudioSolutionFileOperatorServices = _.AddVisualStudioSolutionFileOperatorServices(
                configurationAction,
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction);

            var visualStudioProjectFileOperatorAction = _.AddVisualStudioProjectFileOperatorAction(
                visualStudioSolutionFileOperatorServices.DotnetOperatorAction);

            var visualStudioProjectFileOperatorExtensionAction = _.AddVisualStudioProjectFileOperatorExtensionAction(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorAction);

            var output = new ServiceActionAggregation01()
                .ModifyAs<ServiceActionAggregation01, IServiceActionAggregation01Increment>(increment =>
                {
                    increment.VisualStudioProjectFileOperatorAction = visualStudioProjectFileOperatorAction;
                    increment.VisualStudioProjectFileOperatorExtensionAction = visualStudioProjectFileOperatorExtensionAction;
                })
                .FillFrom(visualStudioSolutionFileOperatorServices);

            return output;
        }
    }
}
