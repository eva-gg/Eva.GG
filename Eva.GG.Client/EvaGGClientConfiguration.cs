using System;
using GraphQL.Client.Http;

namespace Eva.GG.Client
{
	public class EvaGGClientConfiguration
	{
		private EvaGGClientConfiguration(string host, string apiKey)
		{
			Host = host;
			ApiKey = apiKey;
        }

        public string Host { get; }
        public string ApiKey { get; }

        public string Url => $"{Host}/graphql";

        public static EvaGGClientConfiguration Production(string apiKey)
		{
			return new EvaGGClientConfiguration("https://api.eva.gg", apiKey);
		}

        public static EvaGGClientConfiguration Preproduction(string apiKey)
        {
            return new EvaGGClientConfiguration("https://api-preproduction.eva.gg", apiKey);
        }

        public static EvaGGClientConfiguration Custom(string host, string apiKey)
        {
            return new EvaGGClientConfiguration(host, apiKey);
        }
    }
}

