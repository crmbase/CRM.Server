using CRM.Server.Service.Commons.Constants;

namespace CRM.Server.Service.Commons.Helpers;

public class TimeHelper
{
    public static DateTime GetCurrentServerTime()
    {
        var date = DateTime.UtcNow;
        return date.AddHours(TimeConstants.UTC);
    }
}

