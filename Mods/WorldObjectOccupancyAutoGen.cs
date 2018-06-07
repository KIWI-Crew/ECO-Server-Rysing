
// This is an auto-generated file
// Do not modify this file directly

using Eco.Gameplay.Objects;
using Eco.Mods.TechTree;
using Eco.Shared.Math;
using System.Collections.Generic;
using Eco.Gameplay.Items;

namespace Eco.Mods
{
    public class OccupancyInitItem : Item
    {
        static OccupancyInitItem()
        {
            WorldObjectOccupancy.Initialize();
        }
    }

    public static class WorldObjectOccupancy
    {
        public static void Initialize()
        {
            // AnvilObject
            WorldObject.AddOccupancy<AnvilObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            });
            // BakeryOvenObject
            WorldObject.AddOccupancy<BakeryOvenObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(1, 1, 0), typeof(PipeSlotBlock), new Quaternion(0f, 0f, 0f, 1f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            });
            // BigStorageChestObject
            WorldObject.AddOccupancy<BigStorageChestObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            new BlockOccupancy(new Vector3i(1, 0, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            });

            // BlastFurnaceObject
            WorldObject.AddOccupancy<BlastFurnaceObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(1, 4, 1), typeof(PipeSlotBlock), new Quaternion(-0.7071071f, 2.634177E-07f, 2.634179E-07f, 0.7071065f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 2)),
            new BlockOccupancy(new Vector3i(0, 4, 0)),
            new BlockOccupancy(new Vector3i(0, 4, 1)),
            new BlockOccupancy(new Vector3i(0, 4, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 2)),
            new BlockOccupancy(new Vector3i(1, 4, 0)),
            new BlockOccupancy(new Vector3i(1, 4, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 2)),
            new BlockOccupancy(new Vector3i(2, 4, 0)),
            new BlockOccupancy(new Vector3i(2, 4, 1)),
            new BlockOccupancy(new Vector3i(2, 4, 2)),
            });
            // BloomeryObject
            WorldObject.AddOccupancy<BloomeryObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // BookshelfObject
            WorldObject.AddOccupancy<BookshelfObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // BrazierObject
            WorldObject.AddOccupancy<BrazierObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // ButcheryTableObject
            WorldObject.AddOccupancy<ButcheryTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // CampfireObject
            WorldObject.AddOccupancy<CampfireObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            });
            // CandleStandObject
            WorldObject.AddOccupancy<CandleStandObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // CarpentryTableObject
            WorldObject.AddOccupancy<CarpentryTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // CarvedPumpkinObject
            WorldObject.AddOccupancy<CarvedPumpkinObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // CastIronStoveObject
            WorldObject.AddOccupancy<CastIronStoveObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 1, 0), typeof(PipeSlotBlock), new Quaternion(-0.7071068f, 0f, 0f, 0.7071068f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // CeilingCandleObject
            WorldObject.AddOccupancy<CeilingCandleObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // CementKilnObject
            WorldObject.AddOccupancy<CementKilnObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(PipeSlotBlock), new Quaternion(-0.7071068f, 0f, 0f, 0.7071068f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            });
            // ChairObject
            WorldObject.AddOccupancy<ChairObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // CombustionGeneratorObject
            WorldObject.AddOccupancy<CombustionGeneratorObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(2, 2, 2), typeof(PipeSlotBlock), new Quaternion(-0.7071068f, 0f, 0f, 0.7071068f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 2)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 2)),
            new BlockOccupancy(new Vector3i(3, 2, 0)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 2)),
            new BlockOccupancy(new Vector3i(4, 0, 0)),
            new BlockOccupancy(new Vector3i(4, 0, 1)),
            new BlockOccupancy(new Vector3i(4, 0, 2)),
            new BlockOccupancy(new Vector3i(4, 1, 0)),
            new BlockOccupancy(new Vector3i(4, 1, 1)),
            new BlockOccupancy(new Vector3i(4, 1, 2)),
            new BlockOccupancy(new Vector3i(4, 2, 0)),
            new BlockOccupancy(new Vector3i(4, 2, 1)),
            new BlockOccupancy(new Vector3i(4, 2, 2)),
            });
            // ComputerLabObject
            WorldObject.AddOccupancy<ComputerLabObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, -1)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 2, -1)),
            new BlockOccupancy(new Vector3i(-1, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 2, -1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            });
            // ConstructionPostObject
            WorldObject.AddOccupancy<ConstructionPostObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // ContractBoardObject
            WorldObject.AddOccupancy<ContractBoardObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-2, 1, 0)),
            new BlockOccupancy(new Vector3i(-2, 2, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            });
            // CurrencyExchangeObject
            WorldObject.AddOccupancy<CurrencyExchangeObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            });
            // DoorObject
            WorldObject.AddOccupancy<DoorObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(BuildingWorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f), ""),
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(BuildingWorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f), ""),
            });
            // FramedGlassDoorObject
            WorldObject.AddOccupancy<FramedGlassDoorObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(BuildingWorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f), ""),
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(BuildingWorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f), ""),
            });
            // ElectricWallLampObject
            WorldObject.AddOccupancy<ElectricWallLampObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // ElectronicsAssemblyObject
            WorldObject.AddOccupancy<ElectronicsAssemblyObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 2)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 2)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 2)),
            new BlockOccupancy(new Vector3i(3, 2, 0)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 2)),
            new BlockOccupancy(new Vector3i(3, 3, 0)),
            new BlockOccupancy(new Vector3i(3, 3, 1)),
            new BlockOccupancy(new Vector3i(3, 3, 2)),
            });
            // FactoryObject
            WorldObject.AddOccupancy<FactoryObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(3, 2, 0), typeof(PipeSlotBlock), new Quaternion(-0.7071068f, 0f, 0f, 0.7071068f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            });
            // FarmersTableObject
            WorldObject.AddOccupancy<FarmersTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // KilnObject
            WorldObject.AddOccupancy<KilnObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            });
            // KitchenObject
            WorldObject.AddOccupancy<KitchenObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-2, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // LaboratoryObject
            WorldObject.AddOccupancy<LaboratoryObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // LaserObject
            WorldObject.AddOccupancy<LaserObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-2, 0, -2)),
            new BlockOccupancy(new Vector3i(-2, 0, -1)),
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-2, 0, 1)),
            new BlockOccupancy(new Vector3i(-2, 0, 2)),
            new BlockOccupancy(new Vector3i(-2, 1, -2)),
            new BlockOccupancy(new Vector3i(-2, 1, -1)),
            new BlockOccupancy(new Vector3i(-2, 1, 0)),
            new BlockOccupancy(new Vector3i(-2, 1, 1)),
            new BlockOccupancy(new Vector3i(-2, 1, 2)),
            new BlockOccupancy(new Vector3i(-2, 2, -2)),
            new BlockOccupancy(new Vector3i(-2, 2, -1)),
            new BlockOccupancy(new Vector3i(-2, 2, 0)),
            new BlockOccupancy(new Vector3i(-2, 2, 1)),
            new BlockOccupancy(new Vector3i(-2, 2, 2)),
            new BlockOccupancy(new Vector3i(-1, 0, -2)),
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 0, 2)),
            new BlockOccupancy(new Vector3i(-1, 1, -2)),
            new BlockOccupancy(new Vector3i(-1, 1, -1)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 1)),
            new BlockOccupancy(new Vector3i(-1, 1, 2)),
            new BlockOccupancy(new Vector3i(-1, 2, -2)),
            new BlockOccupancy(new Vector3i(-1, 2, -1)),
            new BlockOccupancy(new Vector3i(-1, 2, 0)),
            new BlockOccupancy(new Vector3i(-1, 2, 1)),
            new BlockOccupancy(new Vector3i(-1, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 0, -2)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, -2)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 2, -2)),
            new BlockOccupancy(new Vector3i(0, 2, -1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 0, -2)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, -2)),
            new BlockOccupancy(new Vector3i(1, 1, -1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 2, -2)),
            new BlockOccupancy(new Vector3i(1, 2, -1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 0, -2)),
            new BlockOccupancy(new Vector3i(2, 0, -1)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 1, -2)),
            new BlockOccupancy(new Vector3i(2, 1, -1)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 2, -2)),
            new BlockOccupancy(new Vector3i(2, 2, -1)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            });
            // LatrineObject
            WorldObject.AddOccupancy<LatrineObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // MachineShopObject
            WorldObject.AddOccupancy<MachineShopObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // MillObject
            WorldObject.AddOccupancy<MillObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            });
            // MintObject
            WorldObject.AddOccupancy<MintObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            });
            // OilRefineryObject
            WorldObject.AddOccupancy<OilRefineryObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 7, 4), typeof(PipeSlotBlock), new Quaternion(-0.7071068f, 0f, 0f, 0.7071068f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 0, 3)),
            new BlockOccupancy(new Vector3i(0, 0, 4)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 3)),
            new BlockOccupancy(new Vector3i(0, 1, 4)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 2, 3)),
            new BlockOccupancy(new Vector3i(0, 2, 4)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 2)),
            new BlockOccupancy(new Vector3i(0, 3, 3)),
            new BlockOccupancy(new Vector3i(0, 3, 4)),
            new BlockOccupancy(new Vector3i(0, 4, 0)),
            new BlockOccupancy(new Vector3i(0, 4, 1)),
            new BlockOccupancy(new Vector3i(0, 4, 2)),
            new BlockOccupancy(new Vector3i(0, 4, 3)),
            new BlockOccupancy(new Vector3i(0, 4, 4)),
            new BlockOccupancy(new Vector3i(0, 5, 0)),
            new BlockOccupancy(new Vector3i(0, 5, 1)),
            new BlockOccupancy(new Vector3i(0, 5, 2)),
            new BlockOccupancy(new Vector3i(0, 5, 3)),
            new BlockOccupancy(new Vector3i(0, 5, 4)),
            new BlockOccupancy(new Vector3i(0, 6, 0)),
            new BlockOccupancy(new Vector3i(0, 6, 1)),
            new BlockOccupancy(new Vector3i(0, 6, 2)),
            new BlockOccupancy(new Vector3i(0, 6, 3)),
            new BlockOccupancy(new Vector3i(0, 6, 4)),
            new BlockOccupancy(new Vector3i(0, 7, 0)),
            new BlockOccupancy(new Vector3i(0, 7, 1)),
            new BlockOccupancy(new Vector3i(0, 7, 2)),
            new BlockOccupancy(new Vector3i(0, 7, 3)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 3)),
            new BlockOccupancy(new Vector3i(1, 0, 4)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 3)),
            new BlockOccupancy(new Vector3i(1, 1, 4)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 2, 3)),
            new BlockOccupancy(new Vector3i(1, 2, 4)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 2)),
            new BlockOccupancy(new Vector3i(1, 3, 3)),
            new BlockOccupancy(new Vector3i(1, 3, 4)),
            new BlockOccupancy(new Vector3i(1, 4, 0)),
            new BlockOccupancy(new Vector3i(1, 4, 1)),
            new BlockOccupancy(new Vector3i(1, 4, 2)),
            new BlockOccupancy(new Vector3i(1, 4, 3)),
            new BlockOccupancy(new Vector3i(1, 4, 4)),
            new BlockOccupancy(new Vector3i(1, 5, 0)),
            new BlockOccupancy(new Vector3i(1, 5, 1)),
            new BlockOccupancy(new Vector3i(1, 5, 2)),
            new BlockOccupancy(new Vector3i(1, 5, 3)),
            new BlockOccupancy(new Vector3i(1, 5, 4)),
            new BlockOccupancy(new Vector3i(1, 6, 0)),
            new BlockOccupancy(new Vector3i(1, 6, 1)),
            new BlockOccupancy(new Vector3i(1, 6, 2)),
            new BlockOccupancy(new Vector3i(1, 6, 3)),
            new BlockOccupancy(new Vector3i(1, 6, 4)),
            new BlockOccupancy(new Vector3i(1, 7, 0)),
            new BlockOccupancy(new Vector3i(1, 7, 1)),
            new BlockOccupancy(new Vector3i(1, 7, 2)),
            new BlockOccupancy(new Vector3i(1, 7, 3)),
            new BlockOccupancy(new Vector3i(1, 7, 4)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 3)),
            new BlockOccupancy(new Vector3i(2, 0, 4)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 1, 3)),
            new BlockOccupancy(new Vector3i(2, 1, 4)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 2, 3)),
            new BlockOccupancy(new Vector3i(2, 2, 4)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 2)),
            new BlockOccupancy(new Vector3i(2, 3, 3)),
            new BlockOccupancy(new Vector3i(2, 3, 4)),
            new BlockOccupancy(new Vector3i(2, 4, 0)),
            new BlockOccupancy(new Vector3i(2, 4, 1)),
            new BlockOccupancy(new Vector3i(2, 4, 2)),
            new BlockOccupancy(new Vector3i(2, 4, 3)),
            new BlockOccupancy(new Vector3i(2, 4, 4)),
            new BlockOccupancy(new Vector3i(2, 5, 0)),
            new BlockOccupancy(new Vector3i(2, 5, 1)),
            new BlockOccupancy(new Vector3i(2, 5, 2)),
            new BlockOccupancy(new Vector3i(2, 5, 3)),
            new BlockOccupancy(new Vector3i(2, 5, 4)),
            new BlockOccupancy(new Vector3i(2, 6, 0)),
            new BlockOccupancy(new Vector3i(2, 6, 1)),
            new BlockOccupancy(new Vector3i(2, 6, 2)),
            new BlockOccupancy(new Vector3i(2, 6, 3)),
            new BlockOccupancy(new Vector3i(2, 6, 4)),
            new BlockOccupancy(new Vector3i(2, 7, 0)),
            new BlockOccupancy(new Vector3i(2, 7, 1)),
            new BlockOccupancy(new Vector3i(2, 7, 2)),
            new BlockOccupancy(new Vector3i(2, 7, 3)),
            new BlockOccupancy(new Vector3i(2, 7, 4)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 2)),
            new BlockOccupancy(new Vector3i(3, 0, 3)),
            new BlockOccupancy(new Vector3i(3, 0, 4)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 2)),
            new BlockOccupancy(new Vector3i(3, 1, 3)),
            new BlockOccupancy(new Vector3i(3, 1, 4)),
            new BlockOccupancy(new Vector3i(3, 2, 0)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 2)),
            new BlockOccupancy(new Vector3i(3, 2, 3)),
            new BlockOccupancy(new Vector3i(3, 2, 4)),
            new BlockOccupancy(new Vector3i(3, 3, 0)),
            new BlockOccupancy(new Vector3i(3, 3, 1)),
            new BlockOccupancy(new Vector3i(3, 3, 2)),
            new BlockOccupancy(new Vector3i(3, 3, 3)),
            new BlockOccupancy(new Vector3i(3, 3, 4)),
            new BlockOccupancy(new Vector3i(3, 4, 0)),
            new BlockOccupancy(new Vector3i(3, 4, 1)),
            new BlockOccupancy(new Vector3i(3, 4, 2)),
            new BlockOccupancy(new Vector3i(3, 4, 3)),
            new BlockOccupancy(new Vector3i(3, 4, 4)),
            new BlockOccupancy(new Vector3i(3, 5, 0)),
            new BlockOccupancy(new Vector3i(3, 5, 1)),
            new BlockOccupancy(new Vector3i(3, 5, 2)),
            new BlockOccupancy(new Vector3i(3, 5, 3)),
            new BlockOccupancy(new Vector3i(3, 5, 4)),
            new BlockOccupancy(new Vector3i(3, 6, 0)),
            new BlockOccupancy(new Vector3i(3, 6, 1)),
            new BlockOccupancy(new Vector3i(3, 6, 2)),
            new BlockOccupancy(new Vector3i(3, 6, 3)),
            new BlockOccupancy(new Vector3i(3, 6, 4)),
            new BlockOccupancy(new Vector3i(3, 7, 0)),
            new BlockOccupancy(new Vector3i(3, 7, 1)),
            new BlockOccupancy(new Vector3i(3, 7, 2)),
            new BlockOccupancy(new Vector3i(3, 7, 3)),
            new BlockOccupancy(new Vector3i(3, 7, 4)),
            new BlockOccupancy(new Vector3i(4, 0, 0)),
            new BlockOccupancy(new Vector3i(4, 0, 1)),
            new BlockOccupancy(new Vector3i(4, 0, 2)),
            new BlockOccupancy(new Vector3i(4, 0, 3)),
            new BlockOccupancy(new Vector3i(4, 0, 4)),
            new BlockOccupancy(new Vector3i(4, 1, 0)),
            new BlockOccupancy(new Vector3i(4, 1, 1)),
            new BlockOccupancy(new Vector3i(4, 1, 2)),
            new BlockOccupancy(new Vector3i(4, 1, 3)),
            new BlockOccupancy(new Vector3i(4, 1, 4)),
            new BlockOccupancy(new Vector3i(4, 2, 0)),
            new BlockOccupancy(new Vector3i(4, 2, 1)),
            new BlockOccupancy(new Vector3i(4, 2, 2)),
            new BlockOccupancy(new Vector3i(4, 2, 3)),
            new BlockOccupancy(new Vector3i(4, 2, 4)),
            new BlockOccupancy(new Vector3i(4, 3, 0)),
            new BlockOccupancy(new Vector3i(4, 3, 1)),
            new BlockOccupancy(new Vector3i(4, 3, 2)),
            new BlockOccupancy(new Vector3i(4, 3, 3)),
            new BlockOccupancy(new Vector3i(4, 3, 4)),
            new BlockOccupancy(new Vector3i(4, 4, 0)),
            new BlockOccupancy(new Vector3i(4, 4, 1)),
            new BlockOccupancy(new Vector3i(4, 4, 2)),
            new BlockOccupancy(new Vector3i(4, 4, 3)),
            new BlockOccupancy(new Vector3i(4, 4, 4)),
            new BlockOccupancy(new Vector3i(4, 5, 0)),
            new BlockOccupancy(new Vector3i(4, 5, 1)),
            new BlockOccupancy(new Vector3i(4, 5, 2)),
            new BlockOccupancy(new Vector3i(4, 5, 3)),
            new BlockOccupancy(new Vector3i(4, 5, 4)),
            new BlockOccupancy(new Vector3i(4, 6, 0)),
            new BlockOccupancy(new Vector3i(4, 6, 1)),
            new BlockOccupancy(new Vector3i(4, 6, 2)),
            new BlockOccupancy(new Vector3i(4, 6, 3)),
            new BlockOccupancy(new Vector3i(4, 6, 4)),
            new BlockOccupancy(new Vector3i(4, 7, 0)),
            new BlockOccupancy(new Vector3i(4, 7, 1)),
            new BlockOccupancy(new Vector3i(4, 7, 2)),
            new BlockOccupancy(new Vector3i(4, 7, 3)),
            new BlockOccupancy(new Vector3i(4, 7, 4)),
            });
            // PlanterPotRoundObject
            WorldObject.AddOccupancy<PlanterPotRoundObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(FertileWorldObjectBlock), new Quaternion(2.185569E-08f, 0f, 0f, 1f), ""),
            });
            // PlanterPotSquareObject
            WorldObject.AddOccupancy<PlanterPotSquareObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(FertileWorldObjectBlock), new Quaternion(2.185569E-08f, 0f, 0f, 1f), ""),
            });
            // PropertyClaimObject
            WorldObject.AddOccupancy<PropertyClaimObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // PumpJackObject
            WorldObject.AddOccupancy<PumpJackObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 0)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 3, 0)),
            new BlockOccupancy(new Vector3i(3, 3, 1)),
            new BlockOccupancy(new Vector3i(4, 0, 0)),
            new BlockOccupancy(new Vector3i(4, 0, 1)),
            new BlockOccupancy(new Vector3i(4, 1, 0)),
            new BlockOccupancy(new Vector3i(4, 1, 1)),
            new BlockOccupancy(new Vector3i(4, 2, 0)),
            new BlockOccupancy(new Vector3i(4, 2, 1)),
            new BlockOccupancy(new Vector3i(4, 3, 0)),
            new BlockOccupancy(new Vector3i(4, 3, 1)),
            });
            // MasonryTableObject
            WorldObject.AddOccupancy<MasonryTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // RepairStationObject
            WorldObject.AddOccupancy<RepairStationObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, -1)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // ResearchTableObject
            WorldObject.AddOccupancy<ResearchTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            });
            // RollingMillObject
            WorldObject.AddOccupancy<RollingMillObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            });
            //WorldObject.AddOccupancy<RollingMillObject>(new List<BlockOccupancy>(){
            //new BlockOccupancy(new Vector3i(0, 0, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(0, 0, 1), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(0, 1, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(0, 1, 1), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(0, 2, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(0, 2, 1), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(1, 0, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(1, 0, 1), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(1, 1, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(1, 1, 1), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(1, 2, 0), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //new BlockOccupancy(new Vector3i(1, 2, 1), typeof(WorldObjectBlock), new Quaternion(0f, 0f, 0f, 1f)),
            //});

            // RugLargeObject
            WorldObject.AddOccupancy<RugLargeObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            });
            // RugMediumObject
            WorldObject.AddOccupancy<RugMediumObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            });
            // RugSmallObject
            WorldObject.AddOccupancy<RugSmallObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            });
            // SaltBasketObject
            WorldObject.AddOccupancy<SaltBasketObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // SawmillObject
            WorldObject.AddOccupancy<SawmillObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            });
            // SmallTableObject
            WorldObject.AddOccupancy<SmallTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // SmallWoodSignObject
            WorldObject.AddOccupancy<SmallWoodSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // StockpileObject
            WorldObject.AddOccupancy<StockpileObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-2, 0, -2)),
            new BlockOccupancy(new Vector3i(-2, 0, -1)),
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-2, 0, 1)),
            new BlockOccupancy(new Vector3i(-2, 0, 2)),
            new BlockOccupancy(new Vector3i(-2, 1, -2)),
            new BlockOccupancy(new Vector3i(-2, 1, -1)),
            new BlockOccupancy(new Vector3i(-2, 1, 0)),
            new BlockOccupancy(new Vector3i(-2, 1, 1)),
            new BlockOccupancy(new Vector3i(-2, 1, 2)),
            new BlockOccupancy(new Vector3i(-2, 2, -2)),
            new BlockOccupancy(new Vector3i(-2, 2, -1)),
            new BlockOccupancy(new Vector3i(-2, 2, 0)),
            new BlockOccupancy(new Vector3i(-2, 2, 1)),
            new BlockOccupancy(new Vector3i(-2, 2, 2)),
            new BlockOccupancy(new Vector3i(-2, 3, -2)),
            new BlockOccupancy(new Vector3i(-2, 3, -1)),
            new BlockOccupancy(new Vector3i(-2, 3, 0)),
            new BlockOccupancy(new Vector3i(-2, 3, 1)),
            new BlockOccupancy(new Vector3i(-2, 3, 2)),
            new BlockOccupancy(new Vector3i(-2, 4, -2)),
            new BlockOccupancy(new Vector3i(-2, 4, -1)),
            new BlockOccupancy(new Vector3i(-2, 4, 0)),
            new BlockOccupancy(new Vector3i(-2, 4, 1)),
            new BlockOccupancy(new Vector3i(-2, 4, 2)),
            new BlockOccupancy(new Vector3i(-1, 0, -2)),
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 0, 2)),
            new BlockOccupancy(new Vector3i(-1, 1, -2)),
            new BlockOccupancy(new Vector3i(-1, 1, -1)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 1)),
            new BlockOccupancy(new Vector3i(-1, 1, 2)),
            new BlockOccupancy(new Vector3i(-1, 2, -2)),
            new BlockOccupancy(new Vector3i(-1, 2, -1)),
            new BlockOccupancy(new Vector3i(-1, 2, 0)),
            new BlockOccupancy(new Vector3i(-1, 2, 1)),
            new BlockOccupancy(new Vector3i(-1, 2, 2)),
            new BlockOccupancy(new Vector3i(-1, 3, -2)),
            new BlockOccupancy(new Vector3i(-1, 3, -1)),
            new BlockOccupancy(new Vector3i(-1, 3, 0)),
            new BlockOccupancy(new Vector3i(-1, 3, 1)),
            new BlockOccupancy(new Vector3i(-1, 3, 2)),
            new BlockOccupancy(new Vector3i(-1, 4, -2)),
            new BlockOccupancy(new Vector3i(-1, 4, -1)),
            new BlockOccupancy(new Vector3i(-1, 4, 0)),
            new BlockOccupancy(new Vector3i(-1, 4, 1)),
            new BlockOccupancy(new Vector3i(-1, 4, 2)),
            new BlockOccupancy(new Vector3i(0, 0, -2)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, -2)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 2, -2)),
            new BlockOccupancy(new Vector3i(0, 2, -1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 3, -2)),
            new BlockOccupancy(new Vector3i(0, 3, -1)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 2)),
            new BlockOccupancy(new Vector3i(0, 4, -2)),
            new BlockOccupancy(new Vector3i(0, 4, -1)),
            new BlockOccupancy(new Vector3i(0, 4, 0)),
            new BlockOccupancy(new Vector3i(0, 4, 1)),
            new BlockOccupancy(new Vector3i(0, 4, 2)),
            new BlockOccupancy(new Vector3i(1, 0, -2)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, -2)),
            new BlockOccupancy(new Vector3i(1, 1, -1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 2, -2)),
            new BlockOccupancy(new Vector3i(1, 2, -1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 3, -2)),
            new BlockOccupancy(new Vector3i(1, 3, -1)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 2)),
            new BlockOccupancy(new Vector3i(1, 4, -2)),
            new BlockOccupancy(new Vector3i(1, 4, -1)),
            new BlockOccupancy(new Vector3i(1, 4, 0)),
            new BlockOccupancy(new Vector3i(1, 4, 1)),
            new BlockOccupancy(new Vector3i(1, 4, 2)),
            new BlockOccupancy(new Vector3i(2, 0, -2)),
            new BlockOccupancy(new Vector3i(2, 0, -1)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 1, -2)),
            new BlockOccupancy(new Vector3i(2, 1, -1)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 2, -2)),
            new BlockOccupancy(new Vector3i(2, 2, -1)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 3, -2)),
            new BlockOccupancy(new Vector3i(2, 3, -1)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 2)),
            new BlockOccupancy(new Vector3i(2, 4, -2)),
            new BlockOccupancy(new Vector3i(2, 4, -1)),
            new BlockOccupancy(new Vector3i(2, 4, 0)),
            new BlockOccupancy(new Vector3i(2, 4, 1)),
            new BlockOccupancy(new Vector3i(2, 4, 2)),
            });
            // StoneBrazierObject
            WorldObject.AddOccupancy<StoneBrazierObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // StorageChestObject
            WorldObject.AddOccupancy<StorageChestObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            });
            // StoreObject
            WorldObject.AddOccupancy<StoreObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // StoveObject
            WorldObject.AddOccupancy<StoveObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(PipeSlotBlock), new Quaternion(-0.7071068f, 0f, 0f, 0.7071068f), "ChimneyOut"),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            });
            // StreetlampObject
            WorldObject.AddOccupancy<StreetlampObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 4, 0)),
            });
            // TableObject
            WorldObject.AddOccupancy<TableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            });
            // TailoringTableObject
            WorldObject.AddOccupancy<TailoringTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            });
            // TallowCandleObject
            WorldObject.AddOccupancy<TallowCandleObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // TallowLampObject
            WorldObject.AddOccupancy<TallowLampObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // TallowWallLampObject
            WorldObject.AddOccupancy<TallowWallLampObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // StoneWellObject
            WorldObject.AddOccupancy<StoneWellObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            });
            // TransmissionPoleObject
            WorldObject.AddOccupancy<TransmissionPoleObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 4, 0)),
            new BlockOccupancy(new Vector3i(0, 5, 0)),
            new BlockOccupancy(new Vector3i(0, 6, 0)),
            new BlockOccupancy(new Vector3i(0, 7, 0)),
            });
            // TreasuryObject
            WorldObject.AddOccupancy<TreasuryObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            });
            // WainwrightTableObject
            WorldObject.AddOccupancy<WainwrightTableObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // WallCandleObject
            WorldObject.AddOccupancy<WallCandleObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // WaterwheelObject
            WorldObject.AddOccupancy<WaterwheelObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, -1, -1)),
            new BlockOccupancy(new Vector3i(0, -1, 0)),
            new BlockOccupancy(new Vector3i(0, -1, 1)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            });
            // WindmillObject
            WorldObject.AddOccupancy<WindmillObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-3, -3, 1)),
            new BlockOccupancy(new Vector3i(-3, -2, 1)),
            new BlockOccupancy(new Vector3i(-3, -1, 1)),
            new BlockOccupancy(new Vector3i(-3, 0, 1)),
            new BlockOccupancy(new Vector3i(-3, 1, 1)),
            new BlockOccupancy(new Vector3i(-3, 2, 1)),
            new BlockOccupancy(new Vector3i(-3, 3, 1)),
            new BlockOccupancy(new Vector3i(-2, -3, 1)),
            new BlockOccupancy(new Vector3i(-2, -2, 1)),
            new BlockOccupancy(new Vector3i(-2, -1, 1)),
            new BlockOccupancy(new Vector3i(-2, 0, 1)),
            new BlockOccupancy(new Vector3i(-2, 1, 1)),
            new BlockOccupancy(new Vector3i(-2, 2, 1)),
            new BlockOccupancy(new Vector3i(-2, 3, 1)),
            new BlockOccupancy(new Vector3i(-1, -3, 1)),
            new BlockOccupancy(new Vector3i(-1, -2, 1)),
            new BlockOccupancy(new Vector3i(-1, -1, 1)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 1, 1)),
            new BlockOccupancy(new Vector3i(-1, 2, 1)),
            new BlockOccupancy(new Vector3i(-1, 3, 1)),
            new BlockOccupancy(new Vector3i(0, -3, 1)),
            new BlockOccupancy(new Vector3i(0, -2, 1)),
            new BlockOccupancy(new Vector3i(0, -1, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(1, -3, 1)),
            new BlockOccupancy(new Vector3i(1, -2, 1)),
            new BlockOccupancy(new Vector3i(1, -1, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(2, -3, 1)),
            new BlockOccupancy(new Vector3i(2, -2, 1)),
            new BlockOccupancy(new Vector3i(2, -1, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(3, -3, 1)),
            new BlockOccupancy(new Vector3i(3, -2, 1)),
            new BlockOccupancy(new Vector3i(3, -1, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 3, 1)),
            });
            // WoodenFabricBedObject
            WorldObject.AddOccupancy<WoodenFabricBedObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            });
            // WoodenStrawBedObject
            WorldObject.AddOccupancy<WoodenStrawBedObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, -2)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // WoodSignObject
            WorldObject.AddOccupancy<WoodSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            });
            // WorkbenchObject
            WorldObject.AddOccupancy<WorkbenchObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            });
            // WindTurbineObject
            WorldObject.AddOccupancy<WindTurbineObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 1, -1)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 1)),
            new BlockOccupancy(new Vector3i(-1, 2, -1)),
            new BlockOccupancy(new Vector3i(-1, 2, 0)),
            new BlockOccupancy(new Vector3i(-1, 2, 1)),
            new BlockOccupancy(new Vector3i(-1, 3, -1)),
            new BlockOccupancy(new Vector3i(-1, 3, 0)),
            new BlockOccupancy(new Vector3i(-1, 3, 1)),
            new BlockOccupancy(new Vector3i(-1, 4, -1)),
            new BlockOccupancy(new Vector3i(-1, 4, 0)),
            new BlockOccupancy(new Vector3i(-1, 4, 1)),
            new BlockOccupancy(new Vector3i(-1, 5, -1)),
            new BlockOccupancy(new Vector3i(-1, 5, 0)),
            new BlockOccupancy(new Vector3i(-1, 5, 1)),
            new BlockOccupancy(new Vector3i(-1, 6, -1)),
            new BlockOccupancy(new Vector3i(-1, 6, 0)),
            new BlockOccupancy(new Vector3i(-1, 6, 1)),
            new BlockOccupancy(new Vector3i(-1, 7, -1)),
            new BlockOccupancy(new Vector3i(-1, 7, 0)),
            new BlockOccupancy(new Vector3i(-1, 7, 1)),
            new BlockOccupancy(new Vector3i(-1, 8, -1)),
            new BlockOccupancy(new Vector3i(-1, 8, 0)),
            new BlockOccupancy(new Vector3i(-1, 8, 1)),
            new BlockOccupancy(new Vector3i(-1, 9, -1)),
            new BlockOccupancy(new Vector3i(-1, 9, 0)),
            new BlockOccupancy(new Vector3i(-1, 9, 1)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, -1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 3, -1)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 4, -1)),
            new BlockOccupancy(new Vector3i(0, 4, 0)),
            new BlockOccupancy(new Vector3i(0, 4, 1)),
            new BlockOccupancy(new Vector3i(0, 5, -1)),
            new BlockOccupancy(new Vector3i(0, 5, 0)),
            new BlockOccupancy(new Vector3i(0, 5, 1)),
            new BlockOccupancy(new Vector3i(0, 6, -1)),
            new BlockOccupancy(new Vector3i(0, 6, 0)),
            new BlockOccupancy(new Vector3i(0, 6, 1)),
            new BlockOccupancy(new Vector3i(0, 7, -1)),
            new BlockOccupancy(new Vector3i(0, 7, 0)),
            new BlockOccupancy(new Vector3i(0, 7, 1)),
            new BlockOccupancy(new Vector3i(0, 8, -1)),
            new BlockOccupancy(new Vector3i(0, 8, 0)),
            new BlockOccupancy(new Vector3i(0, 8, 1)),
            new BlockOccupancy(new Vector3i(0, 9, -1)),
            new BlockOccupancy(new Vector3i(0, 9, 0)),
            new BlockOccupancy(new Vector3i(0, 9, 1)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, -1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, -1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 3, -1)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 4, -1)),
            new BlockOccupancy(new Vector3i(1, 4, 0)),
            new BlockOccupancy(new Vector3i(1, 4, 1)),
            new BlockOccupancy(new Vector3i(1, 5, -1)),
            new BlockOccupancy(new Vector3i(1, 5, 0)),
            new BlockOccupancy(new Vector3i(1, 5, 1)),
            new BlockOccupancy(new Vector3i(1, 6, -1)),
            new BlockOccupancy(new Vector3i(1, 6, 0)),
            new BlockOccupancy(new Vector3i(1, 6, 1)),
            new BlockOccupancy(new Vector3i(1, 7, -1)),
            new BlockOccupancy(new Vector3i(1, 7, 0)),
            new BlockOccupancy(new Vector3i(1, 7, 1)),
            new BlockOccupancy(new Vector3i(1, 8, -1)),
            new BlockOccupancy(new Vector3i(1, 8, 0)),
            new BlockOccupancy(new Vector3i(1, 8, 1)),
            new BlockOccupancy(new Vector3i(1, 9, -1)),
            new BlockOccupancy(new Vector3i(1, 9, 0)),
            new BlockOccupancy(new Vector3i(1, 9, 1)),
            });
            // IceboxObject
            WorldObject.AddOccupancy<IceboxObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // RefrigeratorObject
            WorldObject.AddOccupancy<RefrigeratorObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            });
            // TorchStandObject
            WorldObject.AddOccupancy<TorchStandObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // WashboardObject
            WorldObject.AddOccupancy<WashboardObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // WashingMachineObject
            WorldObject.AddOccupancy<WashingMachineObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // PaddedChairObject
            WorldObject.AddOccupancy<PaddedChairObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // CouchObject
            WorldObject.AddOccupancy<CouchObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            });
            // EckoStatueObject
            WorldObject.AddOccupancy<EckoStatueObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // SolarGeneratorObject
            WorldObject.AddOccupancy<SolarGeneratorObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 0, 3)),
            new BlockOccupancy(new Vector3i(0, 0, 4)),
            new BlockOccupancy(new Vector3i(0, 0, 5)),
            new BlockOccupancy(new Vector3i(0, 0, 6)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 3)),
            new BlockOccupancy(new Vector3i(0, 1, 4)),
            new BlockOccupancy(new Vector3i(0, 1, 5)),
            new BlockOccupancy(new Vector3i(0, 1, 6)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 2, 3)),
            new BlockOccupancy(new Vector3i(0, 2, 4)),
            new BlockOccupancy(new Vector3i(0, 2, 5)),
            new BlockOccupancy(new Vector3i(0, 2, 6)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 2)),
            new BlockOccupancy(new Vector3i(0, 3, 3)),
            new BlockOccupancy(new Vector3i(0, 3, 4)),
            new BlockOccupancy(new Vector3i(0, 3, 5)),
            new BlockOccupancy(new Vector3i(0, 3, 6)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 3)),
            new BlockOccupancy(new Vector3i(1, 0, 4)),
            new BlockOccupancy(new Vector3i(1, 0, 5)),
            new BlockOccupancy(new Vector3i(1, 0, 6)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 3)),
            new BlockOccupancy(new Vector3i(1, 1, 4)),
            new BlockOccupancy(new Vector3i(1, 1, 5)),
            new BlockOccupancy(new Vector3i(1, 1, 6)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 2, 3)),
            new BlockOccupancy(new Vector3i(1, 2, 4)),
            new BlockOccupancy(new Vector3i(1, 2, 5)),
            new BlockOccupancy(new Vector3i(1, 2, 6)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 2)),
            new BlockOccupancy(new Vector3i(1, 3, 3)),
            new BlockOccupancy(new Vector3i(1, 3, 4)),
            new BlockOccupancy(new Vector3i(1, 3, 5)),
            new BlockOccupancy(new Vector3i(1, 3, 6)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 3)),
            new BlockOccupancy(new Vector3i(2, 0, 4)),
            new BlockOccupancy(new Vector3i(2, 0, 5)),
            new BlockOccupancy(new Vector3i(2, 0, 6)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 1, 3)),
            new BlockOccupancy(new Vector3i(2, 1, 4)),
            new BlockOccupancy(new Vector3i(2, 1, 5)),
            new BlockOccupancy(new Vector3i(2, 1, 6)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 2, 3)),
            new BlockOccupancy(new Vector3i(2, 2, 4)),
            new BlockOccupancy(new Vector3i(2, 2, 5)),
            new BlockOccupancy(new Vector3i(2, 2, 6)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 2)),
            new BlockOccupancy(new Vector3i(2, 3, 3)),
            new BlockOccupancy(new Vector3i(2, 3, 4)),
            new BlockOccupancy(new Vector3i(2, 3, 5)),
            new BlockOccupancy(new Vector3i(2, 3, 6)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 2)),
            new BlockOccupancy(new Vector3i(3, 0, 3)),
            new BlockOccupancy(new Vector3i(3, 0, 4)),
            new BlockOccupancy(new Vector3i(3, 0, 5)),
            new BlockOccupancy(new Vector3i(3, 0, 6)),
            new BlockOccupancy(new Vector3i(3, 1, 0)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 2)),
            new BlockOccupancy(new Vector3i(3, 1, 3)),
            new BlockOccupancy(new Vector3i(3, 1, 4)),
            new BlockOccupancy(new Vector3i(3, 1, 5)),
            new BlockOccupancy(new Vector3i(3, 1, 6)),
            new BlockOccupancy(new Vector3i(3, 2, 0)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 2)),
            new BlockOccupancy(new Vector3i(3, 2, 3)),
            new BlockOccupancy(new Vector3i(3, 2, 4)),
            new BlockOccupancy(new Vector3i(3, 2, 5)),
            new BlockOccupancy(new Vector3i(3, 2, 6)),
            new BlockOccupancy(new Vector3i(3, 3, 0)),
            new BlockOccupancy(new Vector3i(3, 3, 1)),
            new BlockOccupancy(new Vector3i(3, 3, 2)),
            new BlockOccupancy(new Vector3i(3, 3, 3)),
            new BlockOccupancy(new Vector3i(3, 3, 4)),
            new BlockOccupancy(new Vector3i(3, 3, 5)),
            new BlockOccupancy(new Vector3i(3, 3, 6)),
            new BlockOccupancy(new Vector3i(4, 0, 0)),
            new BlockOccupancy(new Vector3i(4, 0, 1)),
            new BlockOccupancy(new Vector3i(4, 0, 2)),
            new BlockOccupancy(new Vector3i(4, 0, 3)),
            new BlockOccupancy(new Vector3i(4, 0, 4)),
            new BlockOccupancy(new Vector3i(4, 0, 5)),
            new BlockOccupancy(new Vector3i(4, 0, 6)),
            new BlockOccupancy(new Vector3i(4, 1, 0)),
            new BlockOccupancy(new Vector3i(4, 1, 1)),
            new BlockOccupancy(new Vector3i(4, 1, 2)),
            new BlockOccupancy(new Vector3i(4, 1, 3)),
            new BlockOccupancy(new Vector3i(4, 1, 4)),
            new BlockOccupancy(new Vector3i(4, 1, 5)),
            new BlockOccupancy(new Vector3i(4, 1, 6)),
            new BlockOccupancy(new Vector3i(4, 2, 0)),
            new BlockOccupancy(new Vector3i(4, 2, 1)),
            new BlockOccupancy(new Vector3i(4, 2, 2)),
            new BlockOccupancy(new Vector3i(4, 2, 3)),
            new BlockOccupancy(new Vector3i(4, 2, 4)),
            new BlockOccupancy(new Vector3i(4, 2, 5)),
            new BlockOccupancy(new Vector3i(4, 2, 6)),
            new BlockOccupancy(new Vector3i(4, 3, 0)),
            new BlockOccupancy(new Vector3i(4, 3, 1)),
            new BlockOccupancy(new Vector3i(4, 3, 2)),
            new BlockOccupancy(new Vector3i(4, 3, 3)),
            new BlockOccupancy(new Vector3i(4, 3, 4)),
            new BlockOccupancy(new Vector3i(4, 3, 5)),
            new BlockOccupancy(new Vector3i(4, 3, 6)),
            new BlockOccupancy(new Vector3i(5, 0, 0)),
            new BlockOccupancy(new Vector3i(5, 0, 1)),
            new BlockOccupancy(new Vector3i(5, 0, 2)),
            new BlockOccupancy(new Vector3i(5, 0, 3)),
            new BlockOccupancy(new Vector3i(5, 0, 4)),
            new BlockOccupancy(new Vector3i(5, 0, 5)),
            new BlockOccupancy(new Vector3i(5, 0, 6)),
            new BlockOccupancy(new Vector3i(5, 1, 0)),
            new BlockOccupancy(new Vector3i(5, 1, 1)),
            new BlockOccupancy(new Vector3i(5, 1, 2)),
            new BlockOccupancy(new Vector3i(5, 1, 3)),
            new BlockOccupancy(new Vector3i(5, 1, 4)),
            new BlockOccupancy(new Vector3i(5, 1, 5)),
            new BlockOccupancy(new Vector3i(5, 1, 6)),
            new BlockOccupancy(new Vector3i(5, 2, 0)),
            new BlockOccupancy(new Vector3i(5, 2, 1)),
            new BlockOccupancy(new Vector3i(5, 2, 2)),
            new BlockOccupancy(new Vector3i(5, 2, 3)),
            new BlockOccupancy(new Vector3i(5, 2, 4)),
            new BlockOccupancy(new Vector3i(5, 2, 5)),
            new BlockOccupancy(new Vector3i(5, 2, 6)),
            new BlockOccupancy(new Vector3i(5, 3, 0)),
            new BlockOccupancy(new Vector3i(5, 3, 1)),
            new BlockOccupancy(new Vector3i(5, 3, 2)),
            new BlockOccupancy(new Vector3i(5, 3, 3)),
            new BlockOccupancy(new Vector3i(5, 3, 4)),
            new BlockOccupancy(new Vector3i(5, 3, 5)),
            new BlockOccupancy(new Vector3i(5, 3, 6)),
            });
            // FisheryObject
            WorldObject.AddOccupancy<FisheryObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-2, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // SteelCeilingLightObject
            WorldObject.AddOccupancy<SteelCeilingLightObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            });
            // SteelFloorLampObject
            WorldObject.AddOccupancy<SteelFloorLampObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // SteelTableLampObject
            WorldObject.AddOccupancy<SteelTableLampObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // WoodenElevatorObject
            WorldObject.AddOccupancy<WoodenElevatorObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 1, -1)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 1)),
            new BlockOccupancy(new Vector3i(-1, 2, -1)),
            new BlockOccupancy(new Vector3i(-1, 2, 0)),
            new BlockOccupancy(new Vector3i(-1, 2, 1)),
            new BlockOccupancy(new Vector3i(-1, 3, -1)),
            new BlockOccupancy(new Vector3i(-1, 3, 0)),
            new BlockOccupancy(new Vector3i(-1, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 2, -1)),
            new BlockOccupancy(new Vector3i(0, 2, 0)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 3, -1)),
            new BlockOccupancy(new Vector3i(0, 3, 0)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, -1)),
            new BlockOccupancy(new Vector3i(1, 1, 0)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 2, -1)),
            new BlockOccupancy(new Vector3i(1, 2, 0)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 3, -1)),
            new BlockOccupancy(new Vector3i(1, 3, 0)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 0, -1)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 1, -1)),
            new BlockOccupancy(new Vector3i(2, 1, 0)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 2, -1)),
            new BlockOccupancy(new Vector3i(2, 2, 0)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 3, -1)),
            new BlockOccupancy(new Vector3i(2, 3, 0)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            });
            // SmallStandingHewnLogSignObject
            WorldObject.AddOccupancy<SmallStandingHewnLogSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // SmallHangingHewnLogSignObject
            WorldObject.AddOccupancy<SmallHangingHewnLogSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // LargeHangingHewnLogSignObject
            WorldObject.AddOccupancy<LargeHangingHewnLogSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // LargeStandingHewnLogSignObject
            WorldObject.AddOccupancy<LargeStandingHewnLogSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // LargeStandingLumberSignObject
            WorldObject.AddOccupancy<LargeStandingLumberSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // LargeStandingStoneSignObject
            WorldObject.AddOccupancy<LargeStandingStoneSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // LargeHangingLumberSignObject
            WorldObject.AddOccupancy<LargeHangingLumberSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // LargeHangingStoneSignObject
            WorldObject.AddOccupancy<LargeHangingStoneSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 1, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
            // SmallHangingLumberSignObject
            WorldObject.AddOccupancy<SmallHangingLumberSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // SmallHangingStoneSignObject
            WorldObject.AddOccupancy<SmallHangingStoneSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // SmallStandingLumberSignObject
            WorldObject.AddOccupancy<SmallStandingLumberSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
            // SmallStandingStoneSignObject
            WorldObject.AddOccupancy<SmallStandingStoneSignObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
        }
    }
}
