using JetBrains.Annotations;
using Lykke.Quintessence.Domain.Services;

namespace Lykke.BilService.EthereumApi.Domain.Services
{
    [UsedImplicitly]
    public class EthereumAssetService : DefaultAssetServiceBase
    {
        public EthereumAssetService() : base(18, "", "ETH", "ETH")
        {
            
        }
    }
}