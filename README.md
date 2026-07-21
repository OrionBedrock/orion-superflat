# orion:superflat

Registers the **`superflat`** world generator via `IGeneratorRegistry` during plugin **Load** (before world bootstrap freezes generators).

Layers (baseY −64): bedrock → 3× dirt → grass_block (plains biome).

## Manifest

| Field | Value |
|-------|--------|
| id | `orion:superflat` |
| provides | `orion:superflat` |
| depend | none (`orion:minimal-blocks` deferred to phase 28) |

## Build

```bash
dotnet build OrionSuperflat.csproj -c Release
```

Deploy `plugin.json` + `orion.superflat.dll` to `plugins/orion:superflat/`.

For terrain: set `"generator": "superflat"` in the dimension config and delete `worlds/default` so chunks regenerate.

## API

```csharp
context.Registries.Generators.Register("superflat", typeof(SuperFlatWorldGenerator));
```

Subclass `Orion.Api.Worldgen.WorldGeneratorBase` and use `IChunkGenerationContext` (`FillLayer`, `SetSubChunkBiome`, `MarkClean`).

## CI

GitHub Actions: pack SDK from `OrionServerBE@development`, build, `PackageReferenceTests`, smoke boot (plugin load).
