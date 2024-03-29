﻿using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;
using R5T.Magyar.Extensions;

using R5T.D0078.A001;

using R5T.D0079.Default;


namespace R5T.D0079.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServicesAggregation01 AddVisualStudioSolutionAndProjectOperatorServices(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var visualStudioSolutionFileOperatorServices = services.AddVisualStudioSolutionFileOperatorServices(
                configurationAction,
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction);

            var visualStudioProjectFileOperatorAction = services.AddVisualStudioProjectFileOperatorAction_Old(
                visualStudioSolutionFileOperatorServices.DotnetOperatorAction);

            var visualStudioProjectFileOperatorExtensionAction = services.AddVisualStudioProjectFileOperatorExtensionAction_Old(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorAction);

            return new ServicesAggregation01()
                .ModifyAs<ServicesAggregation01, IServicesAggregation01Increment>(increment =>
                {
                    increment.VisualStudioProjectFileOperatorAction = visualStudioProjectFileOperatorAction;
                    increment.VisualStudioProjectFileOperatorExtensionAction = visualStudioProjectFileOperatorExtensionAction;
                })
                .FillFrom(visualStudioSolutionFileOperatorServices);
        }
    }
}
