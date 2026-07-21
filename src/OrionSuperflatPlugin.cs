using Orion.Api.Worldgen;
using Orion.PluginContracts;

namespace OrionSuperflat;

/// <summary>
/// Registers the <c>superflat</c> generator during Load (before world bootstrap freeze).
/// </summary>
public sealed class OrionSuperflatPlugin : IOrionPlugin
{
    public string Id => "orion:superflat";

    public Version Version { get; } = new(1, 0, 0);

    public void Load(IPluginLoadContext context)
    {
        context.Registries.Generators.Register("superflat", typeof(SuperFlatWorldGenerator));
    }

    public void OnEnable(IPluginContext context) => _ = context;

    public void OnWorldInitialize(IWorldInitContext context) => _ = context;

    public void OnDisable(IPluginContext context) => _ = context;
}
