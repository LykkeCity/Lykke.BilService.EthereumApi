using JetBrains.Annotations;
using Lykke.BilService.EthereumApi.Modules;
using Lykke.BilService.EthereumApi.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilService.EthereumApi
{
    [UsedImplicitly]
    public class Startup : ApiStartupBase<EthereumApiSettings>
    {
        protected override string IntegrationName
            => "Ethereum";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<EthereumApiModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}