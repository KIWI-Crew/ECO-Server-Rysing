namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    [RequiresSkill(typeof(IndustrialEngineeringSkill), 1)]   
    public partial class FiberglassHandleRecipe : Recipe
    {
        public FiberglassHandleRecipe()
        {
            this.Products = new CraftingElement[]
            {
                new CraftingElement<FiberglassHandleItem>(1),  
            };
            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<FiberglassItem>(typeof(IndustrialEngineeringEfficiencySkill), 5, IndustrialEngineeringEfficiencySkill.MultiplicativeStrategy),
            };
            this.CraftMinutes = CreateCraftTimeValue(typeof(FiberglassHandleRecipe), Item.Get<FiberglassHandleItem>().UILink(), 0.5f, typeof(IndustrialEngineeringSpeedSkill));    
            this.Initialize("Fiberglass Handle", typeof(FiberglassHandleRecipe));

            CraftingComponent.AddRecipe(typeof(FactoryObject), this);
        }
    }


    [Serialized]
    [Weight(500)]               
    [Currency]              
    public partial class FiberglassHandleItem :
    Item                                     
    {
        public override string FriendlyName { get { return "Fiberglass Handle"; } }
        public override string Description { get { return "A Fiberglass Handle for use in making tools."; } }

    }

}