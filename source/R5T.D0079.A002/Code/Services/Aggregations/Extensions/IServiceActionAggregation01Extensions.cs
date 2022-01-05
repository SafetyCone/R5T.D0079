using System;


namespace R5T.D0079.A002
{
    public static class IServiceActionAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01 other)
            where T : IServiceActionAggregation01
        {
            aggregation.VisualStudioProjectFileOperatorAction = other.VisualStudioProjectFileOperatorAction;
            aggregation.VisualStudioProjectFileOperatorExtensionAction = other.VisualStudioProjectFileOperatorExtensionAction;

            return aggregation;
        }
    }
}
