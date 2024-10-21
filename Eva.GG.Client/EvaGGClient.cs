using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Validation;
using Eva.GG.Client.V2;

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

        private async Task<GraphQLResponse<TResponse>> Send<TResponse>(GraphQLRequest request)
        {
            var response = await _GraphQLClient.SendQueryAsync<TResponse>(request);

            if (response.Errors?.Length > 0)
            {
                throw new ExecutionError(response.Errors[0].Message);
            }


            return response;
        }


        public async Task<ListAllGameItemsGQL.Response> ListGameItems()
        {
            var response = await Send<ListAllGameItemsGQL.Response>(ListAllGameItemsGQL.Request());

            return response.Data;
        }

        public async Task<UpdatePlayerGearSetupGQL.Response> UpdatePlayerGearSetup(UpdatePlayerGearSetupGQL.Variables variables)
        {
            var response = await Send<UpdatePlayerGearSetupGQL.Response>(UpdatePlayerGearSetupGQL.Request(variables));


            return response.Data;
        }

        public async Task<UpdatePlayerProfileGQL.Response> UpdatePlayerProfile(UpdatePlayerProfileGQL.Variables variables)
        {
            var response = await Send<UpdatePlayerProfileGQL.Response>(UpdatePlayerProfileGQL.Request(variables));

            return response.Data;
        }

        public async Task<Eva.GG.Client.V2.GetPlayerByUserIdGQL.Response> GetPlayerByUserId(Eva.GG.Client.V2.GetPlayerByUserIdGQL.Variables variables)
        {
            var response = await Send<Eva.GG.Client.V2.GetPlayerByUserIdGQL.Response>(Eva.GG.Client.V2.GetPlayerByUserIdGQL.Request(variables));
            
            return response.Data;
        }


        public async Task<GetItemListGQL.Response> GetItemList()
        {
            var response = await Send<GetItemListGQL.Response>(GetItemListGQL.Request());

            return response.Data;
        }

    }
}

