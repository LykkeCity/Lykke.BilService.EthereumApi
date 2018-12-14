using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumApi.Domain.Services;
using Lykke.BilService.EthereumApi.Settings;
using Lykke.Quintessence.Core.DependencyInjection;
using Lykke.Quintessence.Core.Telemetry.DependencyInjection;
using Lykke.Quintessence.Domain.Services.DependencyInjection;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilService.EthereumApi.Modules
{
    [UsedImplicitly]
    public class EthereumApiModule : Module
    {
        private readonly IReloadingManager<AppSettings<EthereumApiSettings>> _appSettings;

        public EthereumApiModule(
            IReloadingManager<AppSettings<EthereumApiSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            var chainId = _appSettings.CurrentValue.Api.IsMainNet ? 1 : 3;

            builder
                .UseAITelemetryConsumer()
                .UseAssetService<EthereumAssetService>()
                .UseChainId(chainId);
        }
    }
}