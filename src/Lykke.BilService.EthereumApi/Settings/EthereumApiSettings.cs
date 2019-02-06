using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumApi.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class EthereumApiSettings : ApiSettings
    {
        public bool IsMainNet { get; set; }
    }
}