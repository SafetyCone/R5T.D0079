﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0077; /// <see cref="R5T.D0077.Documentation"/>
using R5T.T0063;


namespace R5T.D0079.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileOperator"/> implementation of <see cref="IVisualStudioProjectFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileOperator(this IServiceCollection services,
            IServiceAction<IDotnetOperator> dotnetOperatorAction)
        {
            services.AddSingleton<IVisualStudioProjectFileOperator, VisualStudioProjectFileOperator>()
                .Run(dotnetOperatorAction);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileOperatorExtension"/> implementation of <see cref="IVisualStudioProjectFileOperatorExtension"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileOperatorExtension(this IServiceCollection services,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction)
        {
            services.AddSingleton<IVisualStudioProjectFileOperatorExtension, VisualStudioProjectFileOperatorExtension>()
                .Run(fileNameOperatorAction)
                .Run(stringlyTypedPathOperatorAction)
                .Run(visualStudioProjectFileOperatorAction)
                ;

            return services;
        }
    }
}
