namespace Zu1779.FCT.Automated.End
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Xunit;

    using Zu1779.FCT.Client.RPGClient;

    public class CharacterTest
    {
        [Fact]
        public async Task Random_generation_success()
        {
            using (var httpClient = new HttpClient())
            {
                var client = new Client("http://localhost:53085/", httpClient);
                var response = await client.RandomAbilitiesAsync(null);
                Assert.Equal(6, response.Count);
            }
        }
    }
}
