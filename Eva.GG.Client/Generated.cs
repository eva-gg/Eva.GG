using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Eva.GG.Client
{

  public class UpdatePlayerGearSetupGQL
  {
    /// <summary>
    /// UpdatePlayerGearSetupGQL.Request 
    /// <para>Required variables:<br/> { data=(UpdatePlayerGearSetupInput) }</para>
    /// <para>Optional variables:<br/> {  }</para>
    /// </summary>
    public static GraphQLRequest Request(object? variables = null)
    {
      return new GraphQLRequest
      {
        Query = UpdatePlayerGearSetupDocument,
        OperationName = "updatePlayerGearSetup",
        Variables = variables
      };
    }

    /// <remarks>This method is obsolete. Use Request instead.</remarks>
    public static GraphQLRequest getUpdatePlayerGearSetupGQL()
    {
      return Request();
    }

    public static string UpdatePlayerGearSetupDocument = @"
        mutation updatePlayerGearSetup($data: UpdatePlayerGearSetupInput!) {
          updatePlayerGearSetup(data: $data) {
            ...PlayerGearSetupFields
          }
        }
        fragment GameItemFields on GameItem {
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
        fragment GameItemGroupFields on GameItemGroup {
          id
          name
          type
        }
        fragment GameItemSkinFields on GameItemSkin {
          id
          name
        }
        fragment PlayerGearSetupFields on PlayerGearSetup {
          id
          defaultClassItemId
          defaultPrimaryGunItemId
          defaultSecondaryGunItemId
          pickList {
            ...PlayerGearSetupItemPickFields
          }
        }
        fragment PlayerGearSetupItemPickFields on PlayerGearSetupItemPick {
          groupId
          gender
          item {
            ...GameItemFields
          }
        }";

    public class Variables
    {

      [JsonProperty("data")]
      public UpdatePlayerGearSetupInput? data { get; set; }

    }

    public class Response
    {

      public class PlayerGearSetupSelection
      {

        [JsonProperty("id")]
        public string? id { get; set; }

        [JsonProperty("defaultClassItemId")]
        public int defaultClassItemId { get; set; }

        [JsonProperty("defaultPrimaryGunItemId")]
        public int defaultPrimaryGunItemId { get; set; }

        [JsonProperty("defaultSecondaryGunItemId")]
        public int defaultSecondaryGunItemId { get; set; }

        public class PlayerGearSetupItemPickSelection
        {

          [JsonProperty("groupId")]
          public int groupId { get; set; }

          [JsonProperty("gender")]
          public GenderEnumType? gender { get; set; }

          public class GameItemSelection
          {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("externalId")]
            public int externalId { get; set; }

            public class GameItemGroupSelection
            {

              [JsonProperty("id")]
              public int id { get; set; }

              [JsonProperty("name")]
              public string? name { get; set; }

              [JsonProperty("type")]
              public ItemTypeEnumType type { get; set; }

            }

            [JsonProperty("group")]
            public GameItemGroupSelection? group { get; set; }

            public class GameItemSkinSelection
            {

              [JsonProperty("id")]
              public int id { get; set; }

              [JsonProperty("name")]
              public string? name { get; set; }

            }

            [JsonProperty("skin")]
            public GameItemSkinSelection? skin { get; set; }

            [JsonProperty("gender")]
            public GenderEnumType? gender { get; set; }

          }

          [JsonProperty("item")]
          public GameItemSelection? item { get; set; }

        }

        [JsonProperty("pickList")]
        public System.Collections.Generic.List<PlayerGearSetupItemPickSelection>? pickList { get; set; }

      }

      [JsonProperty("updatePlayerGearSetup")]
      public PlayerGearSetupSelection? updatePlayerGearSetup { get; set; }

    }

    public static System.Threading.Tasks.Task<GraphQLResponse<Response>> SendMutationAsync(IGraphQLClient client, Variables variables, System.Threading.CancellationToken cancellationToken = default)
    {
      return client.SendMutationAsync<Response>(Request(variables), cancellationToken);
    }

  }


  public class UpdatePlayerProfileGQL
  {
    /// <summary>
    /// UpdatePlayerProfileGQL.Request 
    /// <para>Required variables:<br/> { data=(UpdatePlayerProfileInput) }</para>
    /// <para>Optional variables:<br/> {  }</para>
    /// </summary>
    public static GraphQLRequest Request(object? variables = null)
    {
      return new GraphQLRequest
      {
        Query = UpdatePlayerProfileDocument,
        OperationName = "updatePlayerProfile",
        Variables = variables
      };
    }

    /// <remarks>This method is obsolete. Use Request instead.</remarks>
    public static GraphQLRequest getUpdatePlayerProfileGQL()
    {
      return Request();
    }

    public static string UpdatePlayerProfileDocument = @"
        mutation updatePlayerProfile($data: UpdatePlayerProfileInput!) {
          updatePlayerProfile(data: $data) {
            ...PlayerProfileFields
          }
        }
        fragment PlayerProfileFields on PlayerProfile {
          rightHanded
          lang
        }";

    public class Variables
    {

      [JsonProperty("data")]
      public UpdatePlayerProfileInput? data { get; set; }

    }

    public class Response
    {

      public class PlayerProfileSelection
      {

        [JsonProperty("rightHanded")]
        public bool? rightHanded { get; set; }

        [JsonProperty("lang")]
        public string? lang { get; set; }

      }

      [JsonProperty("updatePlayerProfile")]
      public PlayerProfileSelection? updatePlayerProfile { get; set; }

    }

    public static System.Threading.Tasks.Task<GraphQLResponse<Response>> SendMutationAsync(IGraphQLClient client, Variables variables, System.Threading.CancellationToken cancellationToken = default)
    {
      return client.SendMutationAsync<Response>(Request(variables), cancellationToken);
    }

  }


  public class GetPlayerByUserIdGQL
  {
    /// <summary>
    /// GetPlayerByUserIdGQL.Request 
    /// <para>Required variables:<br/> { userId=(int) }</para>
    /// <para>Optional variables:<br/> {  }</para>
    /// </summary>
    public static GraphQLRequest Request(object? variables = null)
    {
      return new GraphQLRequest
      {
        Query = GetPlayerByUserIdDocument,
        OperationName = "getPlayerByUserId",
        Variables = variables
      };
    }

    /// <remarks>This method is obsolete. Use Request instead.</remarks>
    public static GraphQLRequest getGetPlayerByUserIdGQL()
    {
      return Request();
    }

    public static string GetPlayerByUserIdDocument = @"
        query getPlayerByUserId($userId: Int!) {
          getPlayerByUserId(gameId: 1, userId: $userId) {
            ...PlayerFields
          }
        }
        fragment GameItemFields on GameItem {
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
        fragment GameItemGroupFields on GameItemGroup {
          id
          name
          type
        }
        fragment GameItemSkinFields on GameItemSkin {
          id
          name
        }
        fragment PlayerFields on Player {
          id
          gameId
          user {
            id
            displayName
            firstname
            username
            visitedLocationIdList
          }
          experience(gameId: 1) {
            ...PlayerExperienceFields
          }
          seasonPass {
            active
          }
          profile {
            ...PlayerProfileFields
          }
          gearSetup {
            ...PlayerGearSetupFields
          }
          unlockItems {
            classItemList {
              ...GameItemFields
            }
            weaponItemList {
              ...GameItemFields
            }
          }
        }
        fragment PlayerExperienceFields on PlayerExperience {
          experience
          level
          experienceForCurrentLevel
          experienceForNextLevel
          levelProgressionPercentage
          seasonId
        }
        fragment PlayerGearSetupFields on PlayerGearSetup {
          id
          defaultClassItemId
          defaultPrimaryGunItemId
          defaultSecondaryGunItemId
          pickList {
            ...PlayerGearSetupItemPickFields
          }
        }
        fragment PlayerGearSetupItemPickFields on PlayerGearSetupItemPick {
          groupId
          gender
          item {
            ...GameItemFields
          }
        }
        fragment PlayerProfileFields on PlayerProfile {
          rightHanded
          lang
        }";

    public class Variables
    {

      [JsonProperty("userId")]
      public int userId { get; set; }

    }

    public class Response
    {

      public class PlayerSelection
      {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("gameId")]
        public int gameId { get; set; }

        public class PlayerUserSelection
        {

          [JsonProperty("id")]
          public int id { get; set; }

          [JsonProperty("displayName")]
          public string? displayName { get; set; }

          [JsonProperty("firstname")]
          public string? firstname { get; set; }

          [JsonProperty("username")]
          public string? username { get; set; }

          [JsonProperty("visitedLocationIdList")]
          public System.Collections.Generic.List<int>? visitedLocationIdList { get; set; }

        }

        [JsonProperty("user")]
        public PlayerUserSelection? user { get; set; }

        public class PlayerExperienceSelection
        {

          [JsonProperty("experience")]
          public int experience { get; set; }

          [JsonProperty("level")]
          public int level { get; set; }

          [JsonProperty("experienceForCurrentLevel")]
          public int experienceForCurrentLevel { get; set; }

          [JsonProperty("experienceForNextLevel")]
          public int experienceForNextLevel { get; set; }

          [JsonProperty("levelProgressionPercentage")]
          public double levelProgressionPercentage { get; set; }

          [JsonProperty("seasonId")]
          public int seasonId { get; set; }

        }

        [JsonProperty("experience")]
        public PlayerExperienceSelection? experience { get; set; }

        public class SeasonPassSelection
        {

          [JsonProperty("active")]
          public bool active { get; set; }

        }

        [JsonProperty("seasonPass")]
        public SeasonPassSelection? seasonPass { get; set; }

        public class PlayerProfileSelection
        {

          [JsonProperty("rightHanded")]
          public bool? rightHanded { get; set; }

          [JsonProperty("lang")]
          public string? lang { get; set; }

        }

        [JsonProperty("profile")]
        public PlayerProfileSelection? profile { get; set; }

        public class PlayerGearSetupSelection
        {

          [JsonProperty("id")]
          public string? id { get; set; }

          [JsonProperty("defaultClassItemId")]
          public int defaultClassItemId { get; set; }

          [JsonProperty("defaultPrimaryGunItemId")]
          public int defaultPrimaryGunItemId { get; set; }

          [JsonProperty("defaultSecondaryGunItemId")]
          public int defaultSecondaryGunItemId { get; set; }

          public class PlayerGearSetupItemPickSelection
          {

            [JsonProperty("groupId")]
            public int groupId { get; set; }

            [JsonProperty("gender")]
            public GenderEnumType? gender { get; set; }

            public class GameItemSelection
            {

              [JsonProperty("id")]
              public int id { get; set; }

              [JsonProperty("externalId")]
              public int externalId { get; set; }

              public class GameItemGroupSelection
              {

                [JsonProperty("id")]
                public int id { get; set; }

                [JsonProperty("name")]
                public string? name { get; set; }

                [JsonProperty("type")]
                public ItemTypeEnumType type { get; set; }

              }

              [JsonProperty("group")]
              public GameItemGroupSelection? group { get; set; }

              public class GameItemSkinSelection
              {

                [JsonProperty("id")]
                public int id { get; set; }

                [JsonProperty("name")]
                public string? name { get; set; }

              }

              [JsonProperty("skin")]
              public GameItemSkinSelection? skin { get; set; }

              [JsonProperty("gender")]
              public GenderEnumType? gender { get; set; }

            }

            [JsonProperty("item")]
            public GameItemSelection? item { get; set; }

          }

          [JsonProperty("pickList")]
          public System.Collections.Generic.List<PlayerGearSetupItemPickSelection>? pickList { get; set; }

        }

        [JsonProperty("gearSetup")]
        public PlayerGearSetupSelection? gearSetup { get; set; }

        public class PlayerUnlockItemsSelection
        {

          public class GameItemSelection
          {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("externalId")]
            public int externalId { get; set; }

            public class GameItemGroupSelection
            {

              [JsonProperty("id")]
              public int id { get; set; }

              [JsonProperty("name")]
              public string? name { get; set; }

              [JsonProperty("type")]
              public ItemTypeEnumType type { get; set; }

            }

            [JsonProperty("group")]
            public GameItemGroupSelection? group { get; set; }

            public class GameItemSkinSelection
            {

              [JsonProperty("id")]
              public int id { get; set; }

              [JsonProperty("name")]
              public string? name { get; set; }

            }

            [JsonProperty("skin")]
            public GameItemSkinSelection? skin { get; set; }

            [JsonProperty("gender")]
            public GenderEnumType? gender { get; set; }

          }

          [JsonProperty("classItemList")]
          public System.Collections.Generic.List<GameItemSelection>? classItemList { get; set; }

          [JsonProperty("weaponItemList")]
          public System.Collections.Generic.List<GameItemSelection>? weaponItemList { get; set; }

        }

        [JsonProperty("unlockItems")]
        public PlayerUnlockItemsSelection? unlockItems { get; set; }

      }

      [JsonProperty("getPlayerByUserId")]
      public PlayerSelection? getPlayerByUserId { get; set; }

    }

    public static System.Threading.Tasks.Task<GraphQLResponse<Response>> SendQueryAsync(IGraphQLClient client, Variables variables, System.Threading.CancellationToken cancellationToken = default)
    {
      return client.SendQueryAsync<Response>(Request(variables), cancellationToken);
    }

  }


  public class ListAllGameItemsGQL
  {
    /// <summary>
    /// ListAllGameItemsGQL.Request 
    /// </summary>
    public static GraphQLRequest Request()
    {
      return new GraphQLRequest
      {
        Query = ListAllGameItemsDocument,
        OperationName = "listAllGameItems"
      };
    }

    /// <remarks>This method is obsolete. Use Request instead.</remarks>
    public static GraphQLRequest getListAllGameItemsGQL()
    {
      return Request();
    }

    public static string ListAllGameItemsDocument = @"
        query listAllGameItems {
          listGameItems(gameId: 1) {
            ...GameItemFields
          }
        }
        fragment GameItemFields on GameItem {
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
        fragment GameItemGroupFields on GameItemGroup {
          id
          name
          type
        }
        fragment GameItemSkinFields on GameItemSkin {
          id
          name
        }";


    public class Response
    {

      public class GameItemSelection
      {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("externalId")]
        public int externalId { get; set; }

        public class GameItemGroupSelection
        {

          [JsonProperty("id")]
          public int id { get; set; }

          [JsonProperty("name")]
          public string? name { get; set; }

          [JsonProperty("type")]
          public ItemTypeEnumType type { get; set; }

        }

        [JsonProperty("group")]
        public GameItemGroupSelection? group { get; set; }

        public class GameItemSkinSelection
        {

          [JsonProperty("id")]
          public int id { get; set; }

          [JsonProperty("name")]
          public string? name { get; set; }

        }

        [JsonProperty("skin")]
        public GameItemSkinSelection? skin { get; set; }

        [JsonProperty("gender")]
        public GenderEnumType? gender { get; set; }

      }

      [JsonProperty("listGameItems")]
      public System.Collections.Generic.List<GameItemSelection>? listGameItems { get; set; }

    }

    public static System.Threading.Tasks.Task<GraphQLResponse<Response>> SendQueryAsync(IGraphQLClient client, System.Threading.CancellationToken cancellationToken = default)
    {
      return client.SendQueryAsync<Response>(Request(), cancellationToken);
    }

  }

  public class ActivatePromotionInput
  {

    [JsonProperty("id")]
    public string? id { get; set; }

  }

  public class AddApplicationToJobOfferInput
  {

    [JsonProperty("answer")]
    public string? answer { get; set; }

    [JsonProperty("email")]
    public string? email { get; set; }

    [JsonProperty("firstname")]
    public string? firstname { get; set; }

    [JsonProperty("id")]
    public double id { get; set; }

    [JsonProperty("lastname")]
    public string? lastname { get; set; }

    [JsonProperty("linkedinUrl")]
    public string? linkedinUrl { get; set; }

    [JsonProperty("note")]
    public string? note { get; set; }

    [JsonProperty("phone")]
    public string? phone { get; set; }

    [JsonProperty("resumeFile")]
    public object? resumeFile { get; set; }

  }

  public class AddressInput
  {

    [JsonProperty("city")]
    public string? city { get; set; }

    [JsonProperty("country")]
    public string? country { get; set; }

    [JsonProperty("line1")]
    public string? line1 { get; set; }

    [JsonProperty("postalCode")]
    public string? postalCode { get; set; }

    [JsonProperty("postalcode")]
    public string? postalcode { get; set; }

  }

  public enum AuthorizationActionEnum
  {
    CANCEL,
    CANCEL_BATTLEPASS,
    CLONE_JOB_OFFER,
    COLLECT_PAYMENT,
    CREATE,
    CREATE_EVENT,
    CREATE_GIFT_CARD_CAMPAIGN,
    CREATE_JOB_OFFER,
    CREATE_ORDER_FOR_USER,
    DEACTIVATE_GIFT_CARD_CAMPAIGN,
    DELETE,
    EXPORT,
    FORCE_CANCEL,
    JOIN,
    JOIN_BOOKING,
    LIST,
    LIST_ALL,
    LIST_BATTLEPASS,
    LIST_BOOKING,
    LIST_GIFT_CARDS,
    LIST_GIFT_CARD_CAMPAIGNS,
    LIST_JOB_OFFERS,
    LIST_USER,
    MANAGE,
    READ,
    READ_ACTIVITY,
    READ_BATTLEPASS_NOTES,
    READ_BATTLEPASS_PERCENTAGE,
    READ_BATTLEPASS_QUOTAS,
    READ_GIFT_CARD_CODE,
    READ_INACTIVE,
    READ_JOB_OFFER,
    READ_PUBLIC,
    READ_USERNAME_TOKEN,
    READ_USERS_STATS,
    READ_USER_PROFILE,
    REMOVE_JOB_OFFER,
    SET_BATTLEPASS_PAYMENT_METHOD,
    SET_BATTLEPASS_RENEWAL,
    UPDATE,
    UPDATE_BATTLEPASS_NOTES,
    UPDATE_BATTLEPASS_PERCENTAGE,
    UPDATE_DESCRIPTION,
    UPDATE_ESPORT_OPTION,
    UPDATE_JOB_OFFER,
    UPDATE_ONE_TIME_DETAILS,
    UPDATE_PRICE,
    UPDATE_SHARE_TOTAL_COUNT,
    UPDATE_USER_DETAILS
  }

  public class BattlepassPercentageInput
  {

    [JsonProperty("friday")]
    public int friday { get; set; }

    [JsonProperty("monday")]
    public int monday { get; set; }

    [JsonProperty("saturday")]
    public int saturday { get; set; }

    [JsonProperty("sunday")]
    public int sunday { get; set; }

    [JsonProperty("thursday")]
    public int thursday { get; set; }

    [JsonProperty("tuesday")]
    public int tuesday { get; set; }

    [JsonProperty("wednesday")]
    public int wednesday { get; set; }

  }

  public enum BattlepassStatus
  {
    ACTIVATED,
    CANCELLED,
    FAIL_1,
    FAIL_2
  }

  public enum BattlepassSubscriptionPlanEnum
  {
    ESSENTIAL,
    PLUS,
    ULTRA,
    V2
  }

  public enum BookingCancellationErrorReasonEnum
  {
    ALREADY_CANCELLED,
    HAS_ENDED,
    MAXIMUM_REACHED,
    NOT_AVAILABLE,
    TOO_LATE
  }

  public enum BookingStatusEnum
  {
    CANCELLED,
    CONFIRMED
  }

  public class CartInput
  {

    [JsonProperty("country")]
    public CountryEnum country { get; set; }

    [JsonProperty("items")]
    public System.Collections.Generic.List<CartItemInput>? items { get; set; }

    [JsonProperty("userId")]
    public int? userId { get; set; }

  }

  public class CartItemDataInput
  {

    [JsonProperty("amount")]
    public int? amount { get; set; }

    [JsonProperty("gameId")]
    public int? gameId { get; set; }

    [JsonProperty("giverName")]
    public string? giverName { get; set; }

    [JsonProperty("isCompetitiveMode")]
    public bool? isCompetitiveMode { get; set; }

    [JsonProperty("locationId")]
    public int? locationId { get; set; }

    [JsonProperty("message")]
    public string? message { get; set; }

    [JsonProperty("priceRate")]
    public PriceRateEnum? priceRate { get; set; }

    [JsonProperty("recipientName")]
    public string? recipientName { get; set; }

    [JsonProperty("shareToken")]
    public string? shareToken { get; set; }

    [JsonProperty("slotId")]
    public string? slotId { get; set; }

    [JsonProperty("terrainId")]
    public int? terrainId { get; set; }

  }

  public class CartItemInput
  {

    [JsonProperty("data")]
    public CartItemDataInput? data { get; set; }

    [JsonProperty("productId")]
    public string? productId { get; set; }

    [JsonProperty("quantity")]
    public int quantity { get; set; }

  }

  public class CloseUserAccountInput
  {

    [JsonProperty("password")]
    public string? password { get; set; }

  }

  public class CollectPaymentInput
  {

    [JsonProperty("orderId")]
    public int orderId { get; set; }

  }

  public class ConfirmPaymentInput
  {

    [JsonProperty("paymentId")]
    public int paymentId { get; set; }

    [JsonProperty("paymentMethodProviderId")]
    public string? paymentMethodProviderId { get; set; }

  }

  public class ContactLocationInput
  {

    [JsonProperty("email")]
    public string? email { get; set; }

    [JsonProperty("locationId")]
    public int locationId { get; set; }

    [JsonProperty("message")]
    public string? message { get; set; }

    [JsonProperty("name")]
    public string? name { get; set; }

  }

  public enum CountryEnum
  {
    BH,
    FR,
    MY,
    US
  }

  public class CreateBattlepassInput
  {

    [JsonProperty("country")]
    public CountryEnum country { get; set; }

    [JsonProperty("expirationTimestamp")]
    public object? expirationTimestamp { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<int>? locationIdList { get; set; }

    [JsonProperty("retributionEnabled")]
    public bool retributionEnabled { get; set; }

    [JsonProperty("subscriptionPlan")]
    public BattlepassSubscriptionPlanEnum subscriptionPlan { get; set; }

    [JsonProperty("userId")]
    public int userId { get; set; }

  }

  public class CreateGiftCardCampaignInput
  {

    [JsonProperty("currency")]
    public CurrencyEnum? currency { get; set; }

    [JsonProperty("endsOn")]
    public DateTime endsOn { get; set; }

    [JsonProperty("giftCards")]
    public CreateGiftCardsInput? giftCards { get; set; }

    [JsonProperty("locationId")]
    public int? locationId { get; set; }

    [JsonProperty("locationIds")]
    public System.Collections.Generic.List<int>? locationIds { get; set; }

    [JsonProperty("name")]
    public string? name { get; set; }

    [JsonProperty("redistribution")]
    public double? redistribution { get; set; }

    [JsonProperty("startsOn")]
    public DateTime startsOn { get; set; }

  }

  public class CreateGiftCardsInput
  {

    [JsonProperty("amount")]
    public int amount { get; set; }

    [JsonProperty("quantity")]
    public int quantity { get; set; }

  }

  public class CreateJobOfferInput
  {

    [JsonProperty("contractType")]
    public JobOfferContractTypeEnum contractType { get; set; }

    [JsonProperty("document")]
    public object? document { get; set; }

    [JsonProperty("endsAt")]
    public object? endsAt { get; set; }

    [JsonProperty("location")]
    public JobOfferLocationEnum location { get; set; }

    [JsonProperty("question")]
    public JobOfferQuestionTypeEnum? question { get; set; }

    [JsonProperty("startsAt")]
    public object? startsAt { get; set; }

    [JsonProperty("title")]
    public string? title { get; set; }

    [JsonProperty("url")]
    public string? url { get; set; }

  }

  public class CreateProductPricingInput
  {

    [JsonProperty("priceAmount")]
    public int priceAmount { get; set; }

    [JsonProperty("pricingType")]
    public PricingTypeEnumType pricingType { get; set; }

    [JsonProperty("subscription")]
    public bool subscription { get; set; }

    [JsonProperty("vendorProductId")]
    public string? vendorProductId { get; set; }

  }

  public class CreatePromotionInput
  {

    [JsonProperty("availableFrom")]
    public DateTime availableFrom { get; set; }

    [JsonProperty("availableTo")]
    public DateTime availableTo { get; set; }

    [JsonProperty("code")]
    public string? code { get; set; }

    [JsonProperty("constraint")]
    public PromotionConstraintInput? constraint { get; set; }

    [JsonProperty("discount")]
    public PromotionDiscountInput? discount { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<int>? locationIdList { get; set; }

    [JsonProperty("maxUsage")]
    public int? maxUsage { get; set; }

    [JsonProperty("name")]
    public string? name { get; set; }

  }

  public class CreateStripeSetupIntentInput
  {

    [JsonProperty("providerOptions")]
    public PaymentProviderOptionsInput? providerOptions { get; set; }

  }

  public class CreateUserInput
  {

    [JsonProperty("address")]
    public AddressInput? address { get; set; }

    [JsonProperty("birthdate")]
    public DateTime? birthdate { get; set; }

    [JsonProperty("birthday")]
    public DateTime? birthday { get; set; }

    [JsonProperty("displayName")]
    public string? displayName { get; set; }

    [JsonProperty("email")]
    public string? email { get; set; }

    [JsonProperty("firstName")]
    public string? firstName { get; set; }

    [JsonProperty("gender")]
    public Gender gender { get; set; }

    [JsonProperty("language")]
    public string? language { get; set; }

    [JsonProperty("lastName")]
    public string? lastName { get; set; }

    [JsonProperty("newsletter")]
    public bool newsletter { get; set; }

    [JsonProperty("phone")]
    public string? phone { get; set; }

  }

  public enum CurrencyEnum
  {
    BHD,
    EUR,
    MYR,
    USD
  }

  public enum DashboardTypeEnum
  {
    BATTLEPASS_EVA_MEMBER,
    BATTLEPASS_OPERATOR
  }

  public class DeactivatePromotionInput
  {

    [JsonProperty("id")]
    public string? id { get; set; }

  }

  public class DeletePromotionInput
  {

    [JsonProperty("id")]
    public string? id { get; set; }

  }

  public class DisableUsersESportInput
  {

    [JsonProperty("userIdList")]
    public System.Collections.Generic.List<int>? userIdList { get; set; }

  }

  public enum DiscountCalculationTypeEnum
  {
    AMOUNT,
    PERCENT
  }

  public enum DiscountStatusEnum
  {
    DISABLED,
    EXPIRED,
    NOT_YET_VALID,
    REDEEMED,
    VALID
  }

  public enum DiscountTypeEnum
  {
    COUPON,
    GIFT_CARD
  }

  public class ESportHoursInput
  {

    [JsonProperty("configuration")]
    public HoursConfigurationInput? configuration { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<int>? locationIdList { get; set; }

    [JsonProperty("useAllTerrains")]
    public bool useAllTerrains { get; set; }

  }

  public class EnableUsersESportInput
  {

    [JsonProperty("expiresAt")]
    public DateTime expiresAt { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<int>? locationIdList { get; set; }

    [JsonProperty("userIdList")]
    public System.Collections.Generic.List<int>? userIdList { get; set; }

  }

  public class EventInput
  {

    [JsonProperty("from")]
    public object? from { get; set; }

    [JsonProperty("notes")]
    public string? notes { get; set; }

    [JsonProperty("terrainId")]
    public int? terrainId { get; set; }

    [JsonProperty("title")]
    public string? title { get; set; }

    [JsonProperty("to")]
    public object? to { get; set; }

    [JsonProperty("type")]
    public EventTypeEnum type { get; set; }

  }

  public class EventOptionsInput
  {

    [JsonProperty("force")]
    public bool? force { get; set; }

  }

  public enum EventTypeEnum
  {
    COVID,
    EXCEPTIONAL_CLOSURE,
    INDEFINITE_CLOSURE,
    PRIVATIZATION
  }

  public enum FeatureNameEnumType
  {
    BANCONTACT_PAYMENT_METHOD,
    BATTLEPASS,
    GIFT_CARD,
    ON_SITE_PAYMENT,
    PRIVATIZATION
  }

  public class FiltersDateInput
  {

    [JsonProperty("greaterOrEqual")]
    public object? greaterOrEqual { get; set; }

    [JsonProperty("lowerOrEqual")]
    public object? lowerOrEqual { get; set; }

  }

  public class FindBattlepassQuotaListInput
  {

    [JsonProperty("country")]
    public CountryEnum country { get; set; }

    [JsonProperty("userId")]
    public int? userId { get; set; }

  }

  public class FindGiftCardConfigurationInput
  {

    [JsonProperty("country")]
    public CountryEnum country { get; set; }

  }

  public enum GameIdentifierEnum
  {
    AFTER_H_BATTLE_ARENA,
    AFTER_H_LEGEND_OF_MARS,
    AFTER_H_MOON_OF_THE_DEAD,
    AFTER_H_ZOMBIES,
    DART,
    MULTIGAME_ARCADE_POD
  }

  public enum GameMapEnum
  {
    ARTEFACT,
    ATLANTIS,
    BASTION,
    CERES,
    COLISEUM,
    HELIOS,
    LUNAR_OUTPOST,
    MARS,
    POLARIS,
    SHOWROOM,
    SILVA,
    THE_CLIFF,
    THE_ROCK
  }

  public enum GameModeCategoryEnum
  {
    PVE,
    PVP
  }

  public enum GameModeEnum
  {
    DOMINATION,
    FREE_FOR_ALL,
    MOON_OF_THE_DEAD,
    PVE,
    SKIRMISH,
    TDM,
    ZOMBIES
  }

  public enum GameOutcomeEnum
  {
    DEFEAT,
    DRAW,
    VICTORY
  }

  public enum Gender
  {
    F,
    M,
    O
  }

  public enum GenderEnumType
  {
    FEMALE,
    MALE
  }

  public class GenerateInvoiceInput
  {

    [JsonProperty("orderId")]
    public int orderId { get; set; }

    [JsonProperty("paymentId")]
    public int? paymentId { get; set; }

  }

  public class GetDashboardInput
  {

    [JsonProperty("country")]
    public CountryEnum? country { get; set; }

    [JsonProperty("locationId")]
    public int? locationId { get; set; }

    [JsonProperty("type")]
    public DashboardTypeEnum type { get; set; }

  }

  public class GetPromotionActivityFilterInput
  {

    [JsonProperty("isActive")]
    public bool? isActive { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<double>? locationIdList { get; set; }

    [JsonProperty("promotionId")]
    public string? promotionId { get; set; }

    [JsonProperty("usedBetween")]
    public FiltersDateInput? usedBetween { get; set; }

  }

  public class GetPromotionInput
  {

    [JsonProperty("id")]
    public string? id { get; set; }

  }

  public enum GiftCardCampaignStatusEnum
  {
    ACTIVE,
    DEACTIVATED
  }

  public class HoursConfigurationInput
  {

    [JsonProperty("friday")]
    public System.Collections.Generic.List<TimeRangeInput>? friday { get; set; }

    [JsonProperty("monday")]
    public System.Collections.Generic.List<TimeRangeInput>? monday { get; set; }

    [JsonProperty("saturday")]
    public System.Collections.Generic.List<TimeRangeInput>? saturday { get; set; }

    [JsonProperty("sunday")]
    public System.Collections.Generic.List<TimeRangeInput>? sunday { get; set; }

    [JsonProperty("thursday")]
    public System.Collections.Generic.List<TimeRangeInput>? thursday { get; set; }

    [JsonProperty("tuesday")]
    public System.Collections.Generic.List<TimeRangeInput>? tuesday { get; set; }

    [JsonProperty("wednesday")]
    public System.Collections.Generic.List<TimeRangeInput>? wednesday { get; set; }

  }

  public enum ItemTypeEnumType
  {
    CLASS,
    WEAPON
  }

  public enum JobOfferContractTypeEnum
  {
    FIXED_TERM_CONTRACT,
    FREELANCE,
    INTERNSHIP,
    PERMANENT_CONTRACT,
    STUDY_CONTRACT
  }

  public enum JobOfferLocationEnum
  {
    PARIS_HEADQUARTER,
    REMOTE,
    USA
  }

  public enum JobOfferQuestionTypeEnum
  {
    DO_YOU_LIKE_VIDEO_GAME,
    DO_YOU_LIKE_VR,
    FUTURE_OF_VR_IN_ESPORT,
    LIVE_IN_VIDEO_GAME,
    YOUR_FAVORITE_VIDEO_GAME
  }

  public enum LanguageEnumType
  {
    EN,
    FR
  }

  public class ListBookingOrdersFiltersInput
  {

    [JsonProperty("bookingPassed")]
    public bool bookingPassed { get; set; }

  }

  public class ListConflictingPromotionsInput
  {

    [JsonProperty("id")]
    public string? id { get; set; }

  }

  public class ListProductPricingInput
  {

    [JsonProperty("active")]
    public bool active { get; set; }

    [JsonProperty("vendorProductIdList")]
    public System.Collections.Generic.List<string>? vendorProductIdList { get; set; }

  }

  public class ListPromotionsFiltersInput
  {

    [JsonProperty("availableFrom")]
    public FiltersDateInput? availableFrom { get; set; }

    [JsonProperty("availableTo")]
    public FiltersDateInput? availableTo { get; set; }

    [JsonProperty("isActive")]
    public bool? isActive { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<double>? locationIdList { get; set; }

    [JsonProperty("usedBetween")]
    public FiltersDateInput? usedBetween { get; set; }

  }

  public class ListReviewInput
  {

    [JsonProperty("country")]
    public string? country { get; set; }

    [JsonProperty("language")]
    public string? language { get; set; }

    [JsonProperty("locationId")]
    public int? locationId { get; set; }

  }

  public class ListVendorProductsInput
  {

    [JsonProperty("active")]
    public bool? active { get; set; }

    [JsonProperty("productCategoryList")]
    public System.Collections.Generic.List<ProductCategoryEnum>? productCategoryList { get; set; }

    [JsonProperty("vendorIdList")]
    public System.Collections.Generic.List<string>? vendorIdList { get; set; }

  }

  public class ListVendorsFiltersInput
  {

    [JsonProperty("country")]
    public string? country { get; set; }

    [JsonProperty("productIdList")]
    public System.Collections.Generic.List<string>? productIdList { get; set; }

  }

  public class LocationMenuInput
  {

    [JsonProperty("file")]
    public object? file { get; set; }

    [JsonProperty("url")]
    public string? url { get; set; }

  }

  public class LocationServiceInput
  {

    [JsonProperty("type")]
    public LocationServiceTypeEnum type { get; set; }

  }

  public enum LocationServiceTypeEnum
  {
    DRINK,
    GAMING,
    MEETING_ROOM,
    PARKING,
    RESTAURANT,
    SITTING_AREA,
    SNACK
  }

  public class LocationSessionPriceConfigurationInput
  {

    [JsonProperty("offPeakHourSessionESportPrice")]
    public int? offPeakHourSessionESportPrice { get; set; }

    [JsonProperty("offPeakHourSessionPrice")]
    public int offPeakHourSessionPrice { get; set; }

    [JsonProperty("peakHourSessionESportPrice")]
    public int? peakHourSessionESportPrice { get; set; }

    [JsonProperty("peakHourSessionPrice")]
    public int peakHourSessionPrice { get; set; }

  }

  public class LocationSocialNetworksInput
  {

    [JsonProperty("facebook")]
    public string? facebook { get; set; }

    [JsonProperty("instagram")]
    public string? instagram { get; set; }

    [JsonProperty("tiktok")]
    public string? tiktok { get; set; }

    [JsonProperty("x")]
    public string? x { get; set; }

  }

  public class LoginOAuthInput
  {

    [JsonProperty("isPublic")]
    public bool? isPublic { get; set; }

    [JsonProperty("newsletter")]
    public bool newsletter { get; set; }

    [JsonProperty("username")]
    public string? username { get; set; }

  }

  public enum OAuthProviderEnum
  {
    FACEBOOK,
    GOOGLE
  }

  public class OpeningDayCreateInput
  {

    [JsonProperty("from")]
    public DateTime from { get; set; }

    [JsonProperty("openingHours")]
    public OpeningHoursInput? openingHours { get; set; }

    [JsonProperty("title")]
    public string? title { get; set; }

    [JsonProperty("to")]
    public DateTime to { get; set; }

    [JsonProperty("type")]
    public OpeningDayTypeEnum type { get; set; }

  }

  public class OpeningDayEditInput
  {

    [JsonProperty("create")]
    public OpeningDayCreateInput? create { get; set; }

    [JsonProperty("dryRun")]
    public bool? dryRun { get; set; }

    [JsonProperty("remove")]
    public int? remove { get; set; }

    [JsonProperty("update")]
    public OpeningDayUpdateInput? update { get; set; }

  }

  public enum OpeningDayTypeEnum
  {
    CLASSIC,
    PONCTUAL,
    SPECIAL
  }

  public class OpeningDayUpdateInput
  {

    [JsonProperty("from")]
    public DateTime? from { get; set; }

    [JsonProperty("id")]
    public double id { get; set; }

    [JsonProperty("openingHours")]
    public OpeningHoursInput? openingHours { get; set; }

    [JsonProperty("title")]
    public string? title { get; set; }

    [JsonProperty("to")]
    public DateTime? to { get; set; }

  }

  public class OpeningHourInput
  {

    [JsonProperty("from")]
    public object? from { get; set; }

    [JsonProperty("to")]
    public object? to { get; set; }

  }

  public class OpeningHoursInput
  {

    [JsonProperty("friday")]
    public OpeningHourInput? friday { get; set; }

    [JsonProperty("monday")]
    public OpeningHourInput? monday { get; set; }

    [JsonProperty("saturday")]
    public OpeningHourInput? saturday { get; set; }

    [JsonProperty("sunday")]
    public OpeningHourInput? sunday { get; set; }

    [JsonProperty("thursday")]
    public OpeningHourInput? thursday { get; set; }

    [JsonProperty("tuesday")]
    public OpeningHourInput? tuesday { get; set; }

    [JsonProperty("wednesday")]
    public OpeningHourInput? wednesday { get; set; }

  }

  public enum OrderCollectUnavailabilityReasonEnum
  {
    ATTEMPT_FAILED,
    INCOMPATIBLE,
    MISSING_PAYMENT_METHOD,
    PAID,
    PAYMENT_METHOD_NOT_SUPPORTED
  }

  public enum OrderOriginEnum
  {
    DASHBOARD,
    WEBSITE
  }

  public enum OrderPaymentModeEnum
  {
    DEPOSIT,
    FULL,
    SHARE
  }

  public enum OrderPaymentStatusEnum
  {
    INCOMPLETE,
    PAID,
    UNPAID
  }

  public enum OrderStatusEnum
  {
    CONFIRMED,
    PENDING
  }

  public enum OrderTypeEnum
  {
    BATTLEPASS,
    GIFT_CARD,
    SESSION
  }

  public enum OrderVersionEnum
  {
    V1,
    V2
  }

  public class PageInput
  {

    [JsonProperty("itemsLimit")]
    public int? itemsLimit { get; set; }

    [JsonProperty("page")]
    public int? page { get; set; }

  }

  public class PageRequestInput
  {

    [JsonProperty("limit")]
    public int? limit { get; set; }

    [JsonProperty("page")]
    public int? page { get; set; }

  }

  public enum PaymentMethodType
  {
    BATTLEPASS,
    CARD,
    ON_SITE,
    STRIPE
  }

  public class PaymentProviderOptionsInput
  {

    [JsonProperty("country")]
    public CountryEnum country { get; set; }

    [JsonProperty("locationId")]
    public int? locationId { get; set; }

  }

  public enum PaymentStatusEnum
  {
    FAILED,
    PENDING,
    SUCCEEDED
  }

  public class PeakHoursInput
  {

    [JsonProperty("configuration")]
    public HoursConfigurationInput? configuration { get; set; }

    [JsonProperty("from")]
    public DateTime? from { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<int>? locationIdList { get; set; }

    [JsonProperty("title")]
    public string? title { get; set; }

    [JsonProperty("to")]
    public DateTime? to { get; set; }

  }

  public enum PeakHoursTypeEnum
  {
    NORMAL,
    SPECIAL
  }

  public enum PriceRateEnum
  {
    BATTLEPASS_DISCOUNT,
    BATTLEPASS_ESPORT,
    BATTLEPASS_OFF_PEAK_HOUR_QUOTA,
    BATTLEPASS_PEAK_HOUR_QUOTA,
    NORMAL
  }

  public enum PricingTypeEnumType
  {
    NORMAL,
    OFF_PEAK_HOUR,
    PEAK_HOUR
  }

  public enum ProductCategoryEnum
  {
    GIFT_CARD,
    SESSION,
    SUBSCRIPTION
  }

  public class PromotionConstraintInput
  {

    [JsonProperty("isPeakHour")]
    public bool? isPeakHour { get; set; }

    [JsonProperty("scheduledFrom")]
    public DateTime scheduledFrom { get; set; }

    [JsonProperty("scheduledTo")]
    public DateTime scheduledTo { get; set; }

    [JsonProperty("sessionHoursConfiguration")]
    public HoursConfigurationInput? sessionHoursConfiguration { get; set; }

  }

  public class PromotionDiscountInput
  {

    [JsonProperty("amountOff")]
    public int? amountOff { get; set; }

    [JsonProperty("currency")]
    public CurrencyEnum currency { get; set; }

    [JsonProperty("percentOff")]
    public double? percentOff { get; set; }

  }

  public enum ProviderPaymentMethodType
  {
    BANCONTACT,
    CARD,
    SEPA_DEBIT
  }

  public class RegisterInput
  {

    [JsonProperty("displayName")]
    public string? displayName { get; set; }

    [JsonProperty("email")]
    public string? email { get; set; }

    [JsonProperty("isPublic")]
    public bool? isPublic { get; set; }

    [JsonProperty("language")]
    public string? language { get; set; }

    [JsonProperty("newsletter")]
    public bool newsletter { get; set; }

    [JsonProperty("password")]
    public string? password { get; set; }

  }

  public class RescheduleBookingInput
  {

    [JsonProperty("gameId")]
    public double gameId { get; set; }

    [JsonProperty("slotId")]
    public string? slotId { get; set; }

    [JsonProperty("terrainId")]
    public int? terrainId { get; set; }

  }

  public enum ReviewRatingEnum
  {
    FIVE,
    FOUR,
    ONE,
    THREE,
    TWO
  }

  public enum ScheduleStatusEnum
  {
    OUT_OF_HOURS,
    PLANNED
  }

  public enum SeasonStatusType
  {
    ACTIVE,
    COMING_UP,
    PASSED
  }

  public enum SeatTypeEnum
  {
    PLAYER,
    POD,
    TARGET
  }

  public class SendUpdateUserEmailInput
  {

    [JsonProperty("email")]
    public string? email { get; set; }

    [JsonProperty("userId")]
    public int userId { get; set; }

  }

  public enum SessionLevelEnum
  {
    BEGINNER,
    EXPERT
  }

  public enum SortOrderDirectionEnum
  {
    ASC,
    DESC
  }

  public enum SortOrderLocationsByEnum
  {
    ALPHABETICAL_NAME,
    COUNT_BOOKINGS_MONTHLY,
    GEOLOCATION_POINT
  }

  public class SortOrderLocationsInput
  {

    [JsonProperty("by")]
    public SortOrderLocationsByEnum by { get; set; }

    [JsonProperty("direction")]
    public SortOrderDirectionEnum? direction { get; set; }

    [JsonProperty("geolocationPoint")]
    public System.Collections.Generic.List<double>? geolocationPoint { get; set; }

  }

  public class TimeDataInput
  {

    [JsonProperty("hour")]
    public int hour { get; set; }

    [JsonProperty("minute")]
    public int minute { get; set; }

  }

  public class TimeRangeInput
  {

    [JsonProperty("from")]
    public TimeDataInput? from { get; set; }

    [JsonProperty("to")]
    public TimeDataInput? to { get; set; }

  }

  public class UpdateBattlepassTestingInput
  {

    [JsonProperty("expirationTimestamp")]
    public object? expirationTimestamp { get; set; }

    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("locationId")]
    public int? locationId { get; set; }

    [JsonProperty("status")]
    public BattlepassStatus? status { get; set; }

    [JsonProperty("subscriptionPlan")]
    public BattlepassSubscriptionPlanEnum? subscriptionPlan { get; set; }

  }

  public class UpdateJobOfferInput
  {

    [JsonProperty("contractType")]
    public JobOfferContractTypeEnum contractType { get; set; }

    [JsonProperty("document")]
    public object? document { get; set; }

    [JsonProperty("endsAt")]
    public object? endsAt { get; set; }

    [JsonProperty("id")]
    public double id { get; set; }

    [JsonProperty("location")]
    public JobOfferLocationEnum location { get; set; }

    [JsonProperty("question")]
    public JobOfferQuestionTypeEnum? question { get; set; }

    [JsonProperty("startsAt")]
    public object? startsAt { get; set; }

    [JsonProperty("title")]
    public string? title { get; set; }

    [JsonProperty("url")]
    public string? url { get; set; }

  }

  public class UpdatePaymentIntentInput
  {

    [JsonProperty("paymentId")]
    public int paymentId { get; set; }

    [JsonProperty("paymentMethodProviderId")]
    public string? paymentMethodProviderId { get; set; }

    [JsonProperty("providerPaymentMethodType")]
    public ProviderPaymentMethodType? providerPaymentMethodType { get; set; }

    [JsonProperty("storePaymentMethod")]
    public bool storePaymentMethod { get; set; }

  }

  public class UpdatePlayerExperienceInput
  {

    [JsonProperty("level")]
    public int level { get; set; }

    [JsonProperty("seasonId")]
    public int seasonId { get; set; }

    [JsonProperty("userId")]
    public int userId { get; set; }

  }

  public class UpdatePlayerGearSetupInput
  {

    [JsonProperty("classItemId")]
    public int classItemId { get; set; }

    [JsonProperty("itemIdList")]
    public System.Collections.Generic.List<int>? itemIdList { get; set; }

    [JsonProperty("playerId")]
    public int playerId { get; set; }

    [JsonProperty("primaryGunItemId")]
    public int primaryGunItemId { get; set; }

    [JsonProperty("secondaryGunItemId")]
    public int secondaryGunItemId { get; set; }

  }

  public class UpdatePlayerProfileInput
  {

    [JsonProperty("lang")]
    public LanguageEnumType? lang { get; set; }

    [JsonProperty("playerId")]
    public int playerId { get; set; }

    [JsonProperty("rightHanded")]
    public bool? rightHanded { get; set; }

  }

  public class UpdatePromotionInput
  {

    [JsonProperty("availableFrom")]
    public DateTime availableFrom { get; set; }

    [JsonProperty("availableTo")]
    public DateTime availableTo { get; set; }

    [JsonProperty("code")]
    public string? code { get; set; }

    [JsonProperty("constraint")]
    public PromotionConstraintInput? constraint { get; set; }

    [JsonProperty("discount")]
    public PromotionDiscountInput? discount { get; set; }

    [JsonProperty("id")]
    public string? id { get; set; }

    [JsonProperty("locationIdList")]
    public System.Collections.Generic.List<int>? locationIdList { get; set; }

    [JsonProperty("maxUsage")]
    public int? maxUsage { get; set; }

    [JsonProperty("name")]
    public string? name { get; set; }

  }

  public class UpdateUserEmailInput
  {

    [JsonProperty("password")]
    public string? password { get; set; }

    [JsonProperty("token")]
    public string? token { get; set; }

  }

  public class UpdateUserPasswordInput
  {

    [JsonProperty("currentPassword")]
    public string? currentPassword { get; set; }

    [JsonProperty("password")]
    public string? password { get; set; }

  }

  public enum UserRoleEnum
  {
    MEMBER,
    USER
  }

  public class UserUpdateInput
  {

    [JsonProperty("address")]
    public AddressInput? address { get; set; }

    [JsonProperty("birthdate")]
    public DateTime? birthdate { get; set; }

    [JsonProperty("birthday")]
    public DateTime? birthday { get; set; }

    [JsonProperty("firstName")]
    public string? firstName { get; set; }

    [JsonProperty("gender")]
    public Gender gender { get; set; }

    [JsonProperty("language")]
    public string? language { get; set; }

    [JsonProperty("lastName")]
    public string? lastName { get; set; }

    [JsonProperty("newsletter")]
    public bool newsletter { get; set; }

    [JsonProperty("phone")]
    public string? phone { get; set; }

  }

  public enum WeekDayEnum
  {
    FRIDAY,
    MONDAY,
    SATURDAY,
    SUNDAY,
    THURSDAY,
    TUESDAY,
    WEDNESDAY
  }

}