using System;

public class ReportFactory
{
    public static object Create(Type reportType)
    {
        switch (reportType.ToString())
        {
            case "CustomerReport":
                var custRpt = new CustomerReport();
                custRpt.Date = DateTime.Now;
                return custRpt;
            default:
            case "OrdersReport":
                var ordsRpt = new OrdersReport();
                ordsRpt.Date = DateTime.Now;
                return ordsRpt;
        }
    }

    //public static TReport Create<TReport>()
    //    where TReport : Report
    //{
    //    switch (typeof(TReport).Name)
    //    {
    //        case "CustomerReport":
    //            var custRpt = new CustomerReport();
    //            custRpt.Date = DateTime.Now;
    //            return (TReport)(Report)custRpt;
    //        default:
    //        case "OrdersReport":
    //            var ordsRpt = new OrdersReport();
    //            ordsRpt.Date = DateTime.Now;
    //            return (TReport)(Report)ordsRpt;
    //    }
    //}

    public static TReport Create<TReport>()
        where TReport : IReport, new()
    {
        return new TReport() { Date = DateTime.Now };
    }

}
