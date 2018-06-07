namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    [RequiresSkill(typeof(MetalworkingSkill), 3)]   
    [RepairRequiresSkill(typeof(MetalworkingSkill), 1)]
    public partial class IronScytheRecipe : Recipe
    {
        public IronScytheRecipe()
        {
            this.Products = new CraftingElement[] { new CraftingElement<IronScytheItem>() };
            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<WoodHandleItem>(typeof(MetalworkingEfficiencySkill), 5, MetalworkingEfficiencySkill.MultiplicativeStrategy),
                new CraftingElement<IronIngotItem>(typeof(MetalworkingEfficiencySkill), 20, MetalworkingEfficiencySkill.MultiplicativeStrategy),
            };
            this.CraftMinutes = CreateCraftTimeValue(typeof(IronScytheRecipe), Item.Get<IronScytheItem>().UILink(), 0.5f, typeof(MetalworkingSpeedSkill));
            this.Initialize("Iron Scythe", typeof(IronScytheRecipe));
            CraftingComponent.AddRecipe(typeof(AnvilObject), this);
        }
    }
    [Serialized]
    [Weight(1000)]
    [Category("Tool")]
    public partial class IronScytheItem : ScytheItem
    {

        public override string FriendlyName { get { return "Iron Scythe"; } }
        private static IDynamicValue caloriesBurn = CreateCalorieValue(17, typeof(ScytheEfficiencySkill), typeof(IronScytheItem), new IronScytheItem().UILink());
        public override IDynamicValue CaloriesBurn { get { return caloriesBurn; } }

        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(10, MetalworkingSkill.MultiplicativeStrategy, typeof(MetalworkingSkill), Localizer.Do("repair cost"));
        public override IDynamicValue SkilledRepairCost { get { return skilledRepairCost; } }


        public override float DurabilityRate { get { return DurabilityMax / 500f; } }
        
        public override Item RepairItem         {get{ return Item.Get<IronIngotItem>(); } }
        public override int FullRepairAmount    {get{ return 10; } }
    }
}