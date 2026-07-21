using Orion.Api.Worldgen;

namespace OrionSuperflat;

/// <summary>
/// Superflat layers at baseY −64: bedrock, 3× dirt, grass_block (plains biome).
/// </summary>
public sealed class SuperFlatWorldGenerator : WorldGeneratorBase
{
    private const int BaseY = -64;
    private const int PlainsBiomeId = 1;

    public override string Identifier => "superflat";

    public override void Generate(IChunkGenerationContext context, int chunkX, int chunkZ)
    {
        context.FillLayer(BaseY, "minecraft:bedrock");
        context.SetSubChunkBiome(BaseY, PlainsBiomeId);
        context.FillLayer(BaseY + 1, "minecraft:dirt");
        context.SetSubChunkBiome(BaseY + 1, PlainsBiomeId);
        context.FillLayer(BaseY + 2, "minecraft:dirt");
        context.SetSubChunkBiome(BaseY + 2, PlainsBiomeId);
        context.FillLayer(BaseY + 3, "minecraft:dirt");
        context.SetSubChunkBiome(BaseY + 3, PlainsBiomeId);
        context.FillLayer(BaseY + 4, "minecraft:grass_block");
        context.SetSubChunkBiome(BaseY + 4, PlainsBiomeId);
        context.MarkClean();
    }
}
