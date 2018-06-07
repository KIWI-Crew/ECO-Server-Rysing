namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;

    [RequiresSkill(typeof(MortarProductionSkill), 1)] 
    public class GrindSeaShellToSandRecipe : Recipe
    {
        public GrindSeaShellToSandRecipe()
        {
            this.Products = new CraftingElement[]
            {
               new CraftingElement<SandItem>(1),
            };
            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<SeaShellItem>(typeof(MortarProductionEfficiencySkill), 50, MortarProductionEfficiencySkill.MultiplicativeStrategy), 
            };
            this.Initialize("Grind SeaShell To Sand", typeof(GrindSeaShellToSandRecipe));
            this.CraftMinutes = CreateCraftTimeValue(typeof(GrindSeaShellToSandRecipe), this.UILink(), 5, typeof(MortarProductionSpeedSkill));
            CraftingComponent.AddRecipe(typeof(MasonryTableObject), this);
        }
    }
}