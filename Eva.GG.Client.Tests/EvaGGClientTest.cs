namespace Eva.GG.Client.Tests;

[TestClass]
public class EvaGGClientTest
{
    [TestMethod]
    public async Task ListGameItems()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e"));
        var response = await client.ListGameItems();
        Assert.AreEqual(response.listGameItems?.Count, 363);
    }

    [TestMethod]
    public async Task GetPlayerByUserId()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e"));
        var variables = new GetPlayerByUserIdGQL.Variables();
        variables.userId = 1;
        var response = await client.GetPlayerByUserId(variables);
        Assert.AreEqual(response.getPlayerByUserId?.user?.id, 1);
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
        data.classItemId = 1;
        data.primaryGunItemId = 2;
        data.secondaryGunItemId = 22;
        data.itemIdList = new List<int>() { 1, 2, 22 };
        variables.data = data;

        var response = await client.UpdatePlayerGearSetup(variables);
        Assert.AreEqual(response.updatePlayerGearSetup?.defaultClassItemId, variables.data?.classItemId);
        Assert.AreEqual(response.updatePlayerGearSetup?.defaultPrimaryGunItemId, variables.data?.primaryGunItemId);
        Assert.AreEqual(response.updatePlayerGearSetup?.defaultSecondaryGunItemId, variables.data?.secondaryGunItemId);
    }
}
