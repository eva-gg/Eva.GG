namespace Eva.GG.Client.Tests;

[TestClass]
public class EvaGGClientTest
{
    [TestMethod]
    public async Task ListGameItems()
    {
        var client = new EvaGGClient(EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e"));
        var response = await client.ListGameItems();
        Assert.AreEqual(response.listGameItems.Count, 247);
    }
}
