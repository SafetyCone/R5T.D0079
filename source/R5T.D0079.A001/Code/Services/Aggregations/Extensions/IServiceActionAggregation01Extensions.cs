using System;


namespace R5T.D0079.A001
{
    public static class IServiceActionAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01 other)
            where T : IServiceActionAggregation01
        {
            (aggregation as D0078.A001.IServiceActionAggregation01).FillFrom(other);

            (aggregation as IServiceActionAggregation01Increment).FillFrom(other);

            return aggregation;
        }
    }
}
