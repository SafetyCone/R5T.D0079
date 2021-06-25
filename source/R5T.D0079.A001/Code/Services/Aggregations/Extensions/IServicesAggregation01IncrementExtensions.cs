using System;


namespace R5T.D0079.A001
{
    public static class IServicesAggregation01IncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServicesAggregation01Increment other)
            where T : IServicesAggregation01Increment
        {
            aggregation.VisualStudioProjectFileOperatorAction = other.VisualStudioProjectFileOperatorAction;
            aggregation.VisualStudioProjectFileOperatorExtensionAction = other.VisualStudioProjectFileOperatorExtensionAction;

            return aggregation;
        }
    }
}
