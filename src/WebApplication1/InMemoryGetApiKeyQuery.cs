namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryGetApiKeyQuery : IGetApiKeyQuery
    {
        public Dictionary<string, ApiKey> ApiKeys { get; }

        public Task<ApiKey> Excute(string proviedApiKey)
        {
            _ = ApiKeys.TryGetValue(proviedApiKey, out var apiKey);

            return Task.FromResult(apiKey);
        }

        public InMemoryGetApiKeyQuery()
        {
            var existingApiKeys = new ApiKey[]
            {
                new (1, "Finance", "C5BFF7F0-B4DF-475E-A331-F737424F013C", new DateTime(2019, 01, 01), new []
                {
                    "Employee"
                }),
                new ApiKey(3, "Management", "06795D9D-A770-44B9-9B27-03C6ABDB1BAE", new DateTime(2019, 01, 01),
                new List<string>
                {
                    "Employee","Manager"
                }),
            };

            ApiKeys = existingApiKeys.ToDictionary(x => x.Key, x => x);



        }
    }
}
