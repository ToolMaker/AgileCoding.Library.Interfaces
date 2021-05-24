namespace AgileCoding.Library.Interfaces.ServiceProxies
{
    using AgileCoding.Library.Enums.Integration;

    public interface IServiceProxy
    {
        ServiceRequestTypeEnum RequestType { get; set; }

        string URL { get; set; }
    }
}
