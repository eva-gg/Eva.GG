namespace Eva.GG.Client.Tests;

[TestClass]
public class EvaGGClientTest
{

    [TestMethod]
    public async Task GetPlayerByUserId()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3101/graphql", "8dziu8dza1nNJDzz823e"));
        var variables = new GetPlayerByUserIdGQL.Variables();
        variables.userId = "1";
        var response = await client.GetPlayerByUserId(variables);
        Assert.AreEqual(response.getPlayerByUserId?.userId, "1");
    }

    [TestMethod]
    public async Task GetItemList()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3101/graphql", "8dziu8dza1nNJDzz823e"));
        var response = await client.GetItemList();
        Assert.AreEqual(response.getItemList?.Count, 385);
    }
}
