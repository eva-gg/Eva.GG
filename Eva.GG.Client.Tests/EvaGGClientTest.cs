using Eva.GG.Client.V2;

namespace Eva.GG.Client.Tests;

[TestClass]
public class EvaGGClientTest
{
    [TestMethod]
    public async Task ListGameItems()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e"));
        var response = await client.ListGameItems();
        Assert.AreEqual(response.listGameItems?.Count, 385);
    }

    [TestMethod]
    public async Task GetPlayerByUserId()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3101/graphql", "8dziu8dza1nNJDzz823e"));
        var variables = new Eva.GG.Client.V2.GetPlayerByUserIdGQL.Variables();
        variables.userId = "1";
        var response = await client.GetPlayerByUserId(variables);
        Assert.AreEqual(response.getPlayerByUserId?.userId, "1");
    }


    [TestMethod]
    public async Task UpdatePlayerProfile()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e"));
        var variables = new UpdatePlayerProfileGQL.Variables();
        var data = new UpdatePlayerProfileInput();
        data.playerId = 1;
        data.rightHanded = true;
        data.lang = LanguageEnumType.FR;
        variables.data = data;

        var response = await client.UpdatePlayerProfile(variables);
        Assert.AreEqual(response.updatePlayerProfile?.rightHanded, variables.data.rightHanded);
        Assert.AreEqual(response.updatePlayerProfile?.lang, "FR");
    }

    [TestMethod]
    public async Task UpdatePlayerGearSetup()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e"));
        var variables = new UpdatePlayerGearSetupGQL.Variables();
        var data = new UpdatePlayerGearSetupInput();
        data.playerId = 1;
        data.classItemId = 369;
        data.primaryGunItemId = 2;
        data.secondaryGunItemId = 23;
        data.itemIdList = new List<int>() { 369, 2, 23 };
        variables.data = data;

        var response = await client.UpdatePlayerGearSetup(variables);
        Assert.AreEqual(response.updatePlayerGearSetup?.defaultClassItemId, variables.data?.classItemId);
        Assert.AreEqual(response.updatePlayerGearSetup?.defaultPrimaryGunItemId, variables.data?.primaryGunItemId);
        Assert.AreEqual(response.updatePlayerGearSetup?.defaultSecondaryGunItemId, variables.data?.secondaryGunItemId);
    }

    [TestMethod]
    public async Task GetItemList()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3101/graphql", "8dziu8dza1nNJDzz823e"));
        var response = await client.GetItemList();
        Assert.AreEqual(response.getItemList?.Count, 385);
    }
}
