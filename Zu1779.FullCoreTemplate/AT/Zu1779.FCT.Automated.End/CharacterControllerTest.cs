namespace Zu1779.FCT.Automated.End
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Xunit;

    using Zu1779.FCT.Client.RPGClient;

    public class CharacterControllerTest
    {
        [Fact]
        public async Task Random_abilities_generation_success()
        {
            using (var httpClient = new HttpClient())
            {
                var client = new Client("http://localhost:53085/", httpClient);
                var response = await client.RandomAbilitiesAsync(null);
                Assert.Equal(6, response.Count);
                Assert.All(response, c => Assert.InRange(c, 3, 18));
            }
        }

        [Fact]
        public async Task Random_ability_generation_success()
        {
            using (var httpClient = new HttpClient())
            {
                var client = new Client("http://localhost:53085/", httpClient);
                var response = await client.RandomAbilityAsync();
                Assert.InRange(response, 3, 18);
            }
        }
    }
}
