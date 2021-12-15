using System;

using R5T.Lombardy;

using R5T.D0077; /// <see cref="R5T.D0077.Documentation"/>
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0079.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileOperator"/> implementation of <see cref="IVisualStudioProjectFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioProjectFileOperator> AddVisualStudioProjectFileOperatorAction(this IServiceAction _,
            IServiceAction<IDotnetOperator> dotnetOperatorAction)
        {
            var serviceAction = _.New<IVisualStudioProjectFileOperator>(services => services.AddVisualStudioProjectFileOperator(
                dotnetOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileOperatorExtension"/> implementation of <see cref="IVisualStudioProjectFileOperatorExtension"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioProjectFileOperatorExtension> AddVisualStudioProjectFileOperatorExtensionAction(this IServiceAction _,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction)
        {
            var serviceAction = _.New<IVisualStudioProjectFileOperatorExtension>(services => services.AddVisualStudioProjectFileOperatorExtension(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorAction));

            return serviceAction;
        }
    }
}
