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

    [RequiresSkill(typeof(WoodworkingSkill), 3)]   
    public partial class WoodHandleRecipe : Recipe
    {
        public WoodHandleRecipe()
        {
            this.Products = new CraftingElement[]
            {
                new CraftingElement<WoodHandleItem>(1),  
            };
            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<LogItem>(typeof(WoodworkingEfficiencySkill), 5, WoodworkingEfficiencySkill.MultiplicativeStrategy),
            };
            this.CraftMinutes = CreateCraftTimeValue(typeof(WoodHandleRecipe), Item.Get<WoodHandleItem>().UILink(), 0.5f, typeof(WoodworkingSpeedSkill));    
            this.Initialize("Wood Handle", typeof(WoodHandleRecipe));

            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
    }


    [Serialized]
    [Weight(500)]      
    [Fuel(2000)]          
    [Currency]              
    public partial class WoodHandleItem :
    Item                                     
    {
        public override string FriendlyName { get { return "Wood Handle"; } }
        public override string Description { get { return "A Wooden Handle to be used in making tools."; } }

    }

}