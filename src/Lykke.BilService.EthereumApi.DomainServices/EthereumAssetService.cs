using Lykke.Quintessence.Domain.Services;

namespace Lykke.BilService.EthereumApi.Domain.Services
{
    public class EthereumAssetService : DefaultAssetServiceBase
    {
        public EthereumAssetService() : base(18, "", "ETH", "ETH")
        {
            
        }
    }
}