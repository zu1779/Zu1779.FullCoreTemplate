using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Zu1779.FCT.Client.RPGClient
{
    public interface IRPGClient
    {
        Task GetRpgVersionAsync();
        Task GetRpgVersionAsync(CancellationToken cancellationToken);
        Task GetVersionAsync();
        Task GetVersionAsync(CancellationToken cancellationToken);
        /// <summary>
        /// Get a list of random ability values.
        /// </summary>
        /// <param name="numberOfAbilities">Number of abilities to generate. 6 if not specified.</param>
        /// <returns></returns>
        Task<ICollection<int>> RandomAbilitiesAsync(int? numberOfAbilities);
        Task<ICollection<int>> RandomAbilitiesAsync(int? numberOfAbilities, CancellationToken cancellationToken);
        Task<int> RandomAbilityAsync();
        Task<int> RandomAbilityAsync(CancellationToken cancellationToken);
    }
}