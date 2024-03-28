using REQUESTRESPONSEMODEL;
namespace ISERVICES
{
    public interface IApiPeruService:IDisposable
    {
       ApisPeruPersonaResponse PersonaPorDNI(string dni);
    }
}
