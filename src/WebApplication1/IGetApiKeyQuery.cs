namespace WebApplication1
{
    using System.Threading.Tasks;

    public interface IGetApiKeyQuery
    {
        Task<ApiKey> Excute(string proviedApiKey);
    }
}
