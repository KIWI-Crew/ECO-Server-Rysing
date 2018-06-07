namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Gameplay.Systems.Tooltip;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    
    [Serialized]    
    [RequireComponent(typeof(AttachmentComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]                
    [RequireComponent(typeof(LinkComponent))]                   
    [RequireComponent(typeof(HousingComponent))]                  
    [RequireComponent(typeof(PublicStorageComponent))]                
    [RequireComponent(typeof(SolidGroundComponent))]            
    public partial class IceboxObject : 
        WorldObject    
    {
        public override string FriendlyName { get { return "Icebox"; } } 


        protected override void Initialize()
        {
            System.Type[] types = new System.Type[104];

            types[0] = typeof(AcornPowderItem);
            types[1] = typeof(AmanitaMushroomsItem);
            types[2] = typeof(BakedMeatItem);
            types[3] = typeof(BakedRoastItem);
            types[4] = typeof(BannockItem);
            types[5] = typeof(BasicSaladItem);
            types[6] = typeof(BeanPasteItem);
            types[7] = typeof(BearclawItem);
            types[8] = typeof(BearSUPREMEItem);
            types[9] = typeof(BeetItem);
            types[10] = typeof(BoiledSausageItem);
            types[11] = typeof(BoiledShootsItem);
            types[12] = typeof(BreadItem);
            types[13] = typeof(CamasBreadItem);
            types[14] = typeof(CamasBulbBakeItem);
            types[15] = typeof(CamasMashItem);
            types[16] = typeof(CamasPasteItem);
            types[17] = typeof(CampfireBeansItem);
            types[18] = typeof(CampfireRoastItem);
            types[19] = typeof(CampfireStewItem);
            types[20] = typeof(CerealGermItem);
            types[21] = typeof(CharredBeetItem);
            types[22] = typeof(CharredCamasBulbItem);
            types[23] = typeof(CharredCornItem);
            types[24] = typeof(CharredFishItem);
            types[25] = typeof(CharredMeatItem);
            types[26] = typeof(CharredSausageItem);
            types[27] = typeof(CharredTomatoItem);
            types[28] = typeof(CO2CanisterItem);
            types[29] = typeof(CornItem);
            types[30] = typeof(CornFrittersItem);
            types[31] = typeof(CornmealItem);
            types[32] = typeof(CornStarchItem);
            types[33] = typeof(CriminiMushroomsItem);
            types[34] = typeof(CrimsonSaladItem);
            types[35] = typeof(CrispyBaconItem);
            types[36] = typeof(EcoylentItem);
            types[37] = typeof(ElkTacoItem);
            types[38] = typeof(ElkWellingtonItem);
            types[39] = typeof(FiddleheadsItem);
            types[40] = typeof(FiddleheadSaladItem);
            types[41] = typeof(FireweedShootsItem);
            types[42] = typeof(FlatbreadItem);
            types[43] = typeof(FlourItem);
            types[44] = typeof(FriedHareHaunchesItem);
            types[45] = typeof(FriedTomatoesItem);
            types[46] = typeof(FruitSaladItem);
            types[47] = typeof(GiantCactusFruitItem);
            types[48] = typeof(HuckleberriesItem);
            types[49] = typeof(HuckleberryExtractItem);
            types[50] = typeof(HuckleberryMuffinItem);
            types[51] = typeof(HuckleberryPieItem);
            types[52] = typeof(HydrocolloidsItem);
            types[53] = typeof(InfusedOilItem);
            types[54] = typeof(LiquidNitrogenItem);
            types[55] = typeof(MacaroonsItem);
            types[56] = typeof(MaltodextrinItem);
            types[57] = typeof(MeatPieItem);
            types[58] = typeof(MeatStockItem);
            types[59] = typeof(MilkItem);
            types[60] = typeof(OilItem);
            types[61] = typeof(PreparedMeatItem);
            types[62] = typeof(PreservedMeatItem);
            types[63] = typeof(PricklyPearFruitItem);
            types[64] = typeof(PrimeCutItem);
            types[65] = typeof(RawBaconItem);
            types[66] = typeof(RawFishItem);
            types[67] = typeof(RawMeatItem);
            types[68] = typeof(RawRoastItem);
            types[69] = typeof(RawSausageItem);
            types[70] = typeof(RiceSludgeItem);
            types[71] = typeof(ScrapMeatItem);
            types[72] = typeof(SearedMeatItem);
            types[73] = typeof(SimmeredMeatItem);
            types[74] = typeof(SimpleSyrupItem);
            types[75] = typeof(StuffedTurkeyItem);
            types[76] = typeof(SugarItem);
            types[77] = typeof(SweetSaladItem);
            types[78] = typeof(TallowItem);
            types[79] = typeof(TomatoItem);
            types[80] = typeof(TortillaItem);
            types[81] = typeof(TransglutaminaseItem);
            types[82] = typeof(VegetableMedleyItem);
            types[83] = typeof(VegetableSoupItem);
            types[84] = typeof(VegetableStockItem);
            types[85] = typeof(WheatItem);
            types[86] = typeof(WheatPorridgeItem);
            types[87] = typeof(WildMixItem);
            types[88] = typeof(WildStewItem);
            types[89] = typeof(WiltedFiddleheadsItem);
            types[90] = typeof(YeastItem);
            types[91] = typeof(AcornItem);
            types[92] = typeof(BeansItem);
            types[93] = typeof(CamasBulbItem);
            types[94] = typeof(RiceItem);
            types[95] = typeof(SugarcaneItem);
            types[96] = typeof(FoxCarcassItem);
            types[97] = typeof(HareCarcassItem);
            types[98] = typeof(TurkeyCarcassItem);
            types[99] = typeof(SalmonItem);
            types[100] = typeof(TroutItem);
            types[101] = typeof(TunaItem);
            types[102] = typeof(ClamItem);
            types[103] = typeof(UrchinItem);

            this.GetComponent<MinimapComponent>().Initialize("Housing");
            this.GetComponent<HousingComponent>().Set(IceboxItem.HousingVal);

            var storage = this.GetComponent<PublicStorageComponent>();
            storage.Initialize(12);

            storage.Storage.AddRestriction(
                        new SpecificItemTypesRestriction(types));
        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    public partial class IceboxItem : WorldObjectItem<IceboxObject>
    {
        public override string FriendlyName { get { return "Icebox"; } } 
        public override string Description  { get { return "A box of ice. Only accepts food items"; } }

        static IceboxItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "Kitchen",
                                                    Val = 2,                                   
                                                    TypeForRoomLimit = "Food Storage", 
                                                    DiminishingReturnPercent = 0.3f    
        };}}
    }


    [RequiresSkill(typeof(WoodworkingSkill), 4)]
    public partial class IceboxRecipe : Recipe
    {
        public IceboxRecipe()
        {
            this.Products = new CraftingElement[]
            {
                new CraftingElement<IceboxItem>(),
            };

            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<LogItem>(typeof(WoodworkingEfficiencySkill), 10, WoodworkingEfficiencySkill.MultiplicativeStrategy),
                new CraftingElement<BoardItem>(typeof(WoodworkingEfficiencySkill), 10, WoodworkingEfficiencySkill.MultiplicativeStrategy),   
            };
            SkillModifiedValue value = new SkillModifiedValue(5, WoodworkingSpeedSkill.MultiplicativeStrategy, typeof(WoodworkingSpeedSkill), Localizer.Do("craft time"));
            SkillModifiedValueManager.AddBenefitForObject(typeof(IceboxRecipe), Item.Get<IceboxItem>().UILink(), value);
            SkillModifiedValueManager.AddSkillBenefit(Item.Get<IceboxItem>().UILink(), value);
            this.CraftMinutes = value;
            this.Initialize("Icebox", typeof(IceboxRecipe));
            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
    }
}