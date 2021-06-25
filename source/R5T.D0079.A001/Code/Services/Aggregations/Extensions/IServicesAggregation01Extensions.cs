using System;


namespace R5T.D0079.A001
{
    public static class IServicesAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServicesAggregation01 other)
            where T : IServicesAggregation01
        {
            (aggregation as D0078.A001.IServicesAggregation01).FillFrom(other);

            (aggregation as IServicesAggregation01Increment).FillFrom(other);

            return aggregation;
        }
    }
}
