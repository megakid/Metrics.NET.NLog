using CsvLayout = global::NLog.Layouts.CsvLayout;

namespace Metrics.NLog
{
    [global::NLog.Config.AppDomainFixedOutput]
    [global::NLog.Layouts.Layout("CsvGaugeLayout")]
    [global::NLog.Config.ThreadAgnostic]
    public class CsvGaugeLayout : CsvLayout
    {
        public CsvGaugeLayout()
        {
            this.AddGaugeColumns();

        }
    }

    [global::NLog.Config.AppDomainFixedOutput]
    [global::NLog.Layouts.Layout("CsvCounterLayout")]
    [global::NLog.Config.ThreadAgnostic]
    public class CsvCounterLayout : CsvLayout
    {
        public CsvCounterLayout()
        {
            this.AddCounterColumns();

        }
    }

    [global::NLog.Config.AppDomainFixedOutput]
    [global::NLog.Layouts.Layout("CsvMeterLayout")]
    [global::NLog.Config.ThreadAgnostic]
    public class CsvMeterLayout : CsvLayout
    {
        public CsvMeterLayout()
        {
            this.AddMeterColumns();

        }
    }

    [global::NLog.Config.AppDomainFixedOutput]
    [global::NLog.Layouts.Layout("CsvHistogramLayout")]
    [global::NLog.Config.ThreadAgnostic]
    public class CsvHistogramLayout : CsvLayout
    {
        public CsvHistogramLayout()
        {
            this.AddHistogramColumns();

        }
    }

    [global::NLog.Config.AppDomainFixedOutput]
    [global::NLog.Layouts.Layout("CsvTimerLayout")]
    [global::NLog.Config.ThreadAgnostic]
    public class CsvTimerLayout : CsvLayout
    {
        public CsvTimerLayout()
        {
            this.AddTimerColumns();

        }
    }
}
