using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumApi.Settings;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumApi.Modules
{
    [UsedImplicitly]
    public class EthereumApiModule : Module
    {
        private readonly AppSettings<EthereumApiSettings> _appSettings;

        public EthereumApiModule(
            AppSettings<EthereumApiSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}