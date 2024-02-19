using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace Eva.GG.Client
{
	public class EvaGGClient
	{
        public EvaGGClient(EvaGGClientConfiguration configuration)
        {
            Configuration = configuration;
            _GraphQLClient = new GraphQLHttpClient(Configuration.Url, new NewtonsoftJsonSerializer());
            _GraphQLClient.HttpClient.DefaultRequestHeaders.Add("api-key", Configuration.ApiKey);
        }

        private readonly GraphQLHttpClient _GraphQLClient;

        public EvaGGClientConfiguration Configuration { get; }

        public async Task<ListGameItemsGQL.Response> ListGameItems()
        {
            var response = await _GraphQLClient.SendQueryAsync<ListGameItemsGQL.Response>(ListGameItemsGQL.Request(new ListGameItemsGQL.Variables { gameId = 1 }));

            return response.Data;
        }
    }
}

