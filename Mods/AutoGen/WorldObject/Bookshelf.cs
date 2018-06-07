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
    public partial class BookshelfObject : 
        WorldObject    
    {
        public override string FriendlyName { get { return "Bookshelf"; } } 


        protected override void Initialize()
        {
            System.Type[] types = new System.Type[54];

            types[0] = typeof(AdvancedBakingSkillBook);
            types[1] = typeof(AdvancedCampfireCookingSkillBook);
            types[2] = typeof(AdvancedCookingSkillBook);
            types[3] = typeof(AdvancedSmeltingSkillBook);
            types[4] = typeof(BakingSkillBook);
            types[5] = typeof(BasicEngineeringSkillBook);
            types[6] = typeof(BricklayingSkillBook);
            types[7] = typeof(ButcherySkillBook);
            types[8] = typeof(CementSkillBook);
            types[9] = typeof(CookingSkillBook);
            types[10] = typeof(CuttingEdgeCookingSkillBook);
            types[11] = typeof(ElectronicsSkillBook);
            types[12] = typeof(FarmingSkillBook);
            types[13] = typeof(FertilizersSkillBook);
            types[14] = typeof(GlassworkingSkillBook);
            types[15] = typeof(IndustrySkillBook);
            types[16] = typeof(LumberSkillBook);
            types[17] = typeof(MechanicsSkillBook);
            types[18] = typeof(MetalConstructionSkillBook);
            types[19] = typeof(MillingSkillBook);
            types[20] = typeof(OilDrillingSkillBook);
            types[21] = typeof(PaperMillingSkillBook);
            types[22] = typeof(SmeltingSkillBook);
            types[23] = typeof(StoneConstructionSkillBook);
            types[24] = typeof(TailoringSkillBook);
            types[25] = typeof(WoodConstructionSkillBook);

            types[26] = typeof(AdvancedBakingSkillScroll);
            types[27] = typeof(AdvancedCampfireCookingSkillScroll);
            types[28] = typeof(AdvancedCookingSkillScroll);
            types[29] = typeof(AdvancedSmeltingSkillScroll);
            types[30] = typeof(BakingSkillScroll);
            types[31] = typeof(BasicEngineeringSkillScroll);
            types[32] = typeof(BricklayingSkillScroll);
            types[33] = typeof(ButcherySkillScroll);
            types[34] = typeof(CementSkillScroll);
            types[35] = typeof(CookingSkillScroll);
            types[36] = typeof(CuttingEdgeCookingSkillScroll);
            types[37] = typeof(ElectronicsSkillScroll);
            types[38] = typeof(FarmingSkillScroll);
            types[39] = typeof(FertilizersSkillScroll);
            types[40] = typeof(GlassworkingSkillScroll);
            types[41] = typeof(IndustrySkillScroll);
            types[42] = typeof(LumberSkillScroll);
            types[43] = typeof(MechanicsSkillScroll);
            types[44] = typeof(MetalConstructionSkillScroll);
            types[45] = typeof(MillingSkillScroll);
            types[46] = typeof(OilDrillingSkillScroll);
            types[47] = typeof(PaperMillingSkillScroll);
            types[48] = typeof(SmeltingSkillScroll);
            types[49] = typeof(StoneConstructionSkillScroll);
            types[50] = typeof(TailoringSkillScroll);
            types[51] = typeof(WoodConstructionSkillScroll);

            var storage = this.GetComponent<PublicStorageComponent>();
            storage.Initialize(54);
            storage.Storage.AddRestriction(
                new SpecificItemTypesRestriction(types)
            );
            this.GetComponent<MinimapComponent>().Initialize("Misc");
            this.GetComponent<HousingComponent>().Set(BookshelfItem.HousingVal);


        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    public partial class BookshelfItem : WorldObjectItem<BookshelfObject>
    {
        public override string FriendlyName { get { return "Bookshelf"; } } 
        public override string Description  { get { return  "A place to store knowledge and information; leads to the town hall."; } }

        static BookshelfItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 2,                                   
                                                    TypeForRoomLimit = "Shelves", 
                                                    DiminishingReturnPercent = 0.7f    
        };}}
    }


    [RequiresSkill(typeof(LumberWoodworkingSkill), 2)]
    public partial class BookshelfRecipe : Recipe
    {
        public BookshelfRecipe()
        {
            this.Products = new CraftingElement[]
            {
                new CraftingElement<BookshelfItem>(),
            };

            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<LumberItem>(typeof(LumberWoodworkingEfficiencySkill), 20, LumberWoodworkingEfficiencySkill.MultiplicativeStrategy),
                new CraftingElement<PaperItem>(typeof(LumberWoodworkingEfficiencySkill), 100, LumberWoodworkingEfficiencySkill.MultiplicativeStrategy),   
            };
            SkillModifiedValue value = new SkillModifiedValue(1, LumberWoodworkingSpeedSkill.MultiplicativeStrategy, typeof(LumberWoodworkingSpeedSkill), Localizer.Do("craft time"));
            SkillModifiedValueManager.AddBenefitForObject(typeof(BookshelfRecipe), Item.Get<BookshelfItem>().UILink(), value);
            SkillModifiedValueManager.AddSkillBenefit(Item.Get<BookshelfItem>().UILink(), value);
            this.CraftMinutes = value;
            this.Initialize("Bookshelf", typeof(BookshelfRecipe));
            CraftingComponent.AddRecipe(typeof(SawmillObject), this);
        }
    }
}