using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Eva.GG.Client.V2 {

    public class GetItemListGQL {
      /// <summary>
      /// GetItemListGQL.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = GetItemListDocument,
          OperationName = "getItemList"
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetItemListGQL() {
        return Request();
      }
      
      public static string GetItemListDocument = @"
        query getItemList {
          getItemList {
            ...GameItemFields
          }
        }
        fragment GameItemFields on ItemType {
          id
          externalId
          group {
            ...GameItemGroupFields
          }
          skin {
            ...GameItemSkinFields
          }
          gender
        }
        fragment GameItemGroupFields on ItemGroupType {
          id
          name
          type
        }
        fragment GameItemSkinFields on ItemSkinType {
          id
          name
        }";
            
      
      public class Response {
      
        public class ItemTypeSelection {
        
          [JsonProperty("id")]
          public string id { get; set; }
          
          [JsonProperty("externalId")]
          public string externalId { get; set; }
          
          public class ItemGroupTypeSelection {
          
            [JsonProperty("id")]
            public string id { get; set; }
            
            [JsonProperty("name")]
            public string name { get; set; }
            
            [JsonProperty("type")]
            public ItemTypeEnumType type { get; set; }
            
          }
          
          [JsonProperty("group")]
          public ItemGroupTypeSelection group { get; set; }
          
          public class ItemSkinTypeSelection {
          
            [JsonProperty("id")]
            public string id { get; set; }
            
            [JsonProperty("name")]
            public string name { get; set; }
            
          }
          
          [JsonProperty("skin")]
          public ItemSkinTypeSelection skin { get; set; }
          
          [JsonProperty("gender")]
          public GenderEnumType? gender { get; set; }
          
        }
        
        [JsonProperty("getItemList")]
        public System.Collections.Generic.List<ItemTypeSelection> getItemList { get; set; }
        
      }
      
      public static System.Threading.Tasks.Task<GraphQLResponse<Response>> SendQueryAsync(IGraphQLClient client, System.Threading.CancellationToken cancellationToken = default) {
        return client.SendQueryAsync<Response>(Request(), cancellationToken);
      }
      
    }
    

    public class GetPlayerByUserIdGQL {
      /// <summary>
      /// GetPlayerByUserIdGQL.Request 
      /// <para>Required variables:<br/> { userId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GetPlayerByUserIdDocument,
          OperationName = "getPlayerByUserId",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetPlayerByUserIdGQL() {
        return Request();
      }
      
      public static string GetPlayerByUserIdDocument = @"
        query getPlayerByUserId($userId: ID!) {
          getPlayerByUserId(userId: $userId) {
            ...PlayerFields
          }
        }
        fragment PlayerFields on PlayerType {
          id
          gameId
          userId
          profile {
            ...PlayerProfileFields
          }
        }
        fragment PlayerProfileFields on PlayerProfileType {
          language
          isRightHanded
        }";
            
      public class Variables {
      
        [JsonProperty("userId")]
        public string userId { get; set; }
        
      }
      
      public class Response {
      
        public class PlayerTypeSelection {
        
          [JsonProperty("id")]
          public string id { get; set; }
          
          [JsonProperty("gameId")]
          public string gameId { get; set; }
          
          [JsonProperty("userId")]
          public string userId { get; set; }
          
          public class PlayerProfileTypeSelection {
          
            [JsonProperty("language")]
            public LanguageEnum? language { get; set; }
            
            [JsonProperty("isRightHanded")]
            public bool? isRightHanded { get; set; }
            
          }
          
          [JsonProperty("profile")]
          public PlayerProfileTypeSelection profile { get; set; }
          
        }
        
        [JsonProperty("getPlayerByUserId")]
        public PlayerTypeSelection getPlayerByUserId { get; set; }
        
      }
      
      public static System.Threading.Tasks.Task<GraphQLResponse<Response>> SendQueryAsync(IGraphQLClient client, Variables variables, System.Threading.CancellationToken cancellationToken = default) {
        return client.SendQueryAsync<Response>(Request(variables), cancellationToken);
      }
      
    }
    
    public enum GenderEnumType {
      FEMALE,
      MALE
    }
    
    public enum ItemTypeEnumType {
      CLASS,
      WEAPON
    }
    
    public enum LanguageEnum {
      EN,
      FR
    }
    
}