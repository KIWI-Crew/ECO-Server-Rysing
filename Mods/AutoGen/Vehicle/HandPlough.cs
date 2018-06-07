namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Components.VehicleModules;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    
    [Serialized]
    [Weight(15000)]  
    public class HandPloughItem : WorldObjectItem<HandPloughObject>
    {
        public override string FriendlyName         { get { return "Hand Plough"; } }
        public override string Description          { get { return "Small wheelbarrow for hauling minimal loads."; } }
    }

    [RequiresSkill(typeof(PrimitiveMechanicsSkill), 1)] 
    public class HandPloughRecipe : Recipe
    {
        public HandPloughRecipe()
        {
            this.Products = new CraftingElement[]
            {
                new CraftingElement<HandPloughItem>(),
            };
            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<BoardItem>(typeof(PrimitiveMechanicsEfficiencySkill), 50, PrimitiveMechanicsEfficiencySkill.MultiplicativeStrategy),
                new CraftingElement<IronIngotItem>(typeof(PrimitiveMechanicsEfficiencySkill), 20, PrimitiveMechanicsEfficiencySkill.MultiplicativeStrategy),
            };
            this.CraftMinutes = new ConstantValue(5);

            this.Initialize("Hand Plough", typeof(HandPloughRecipe));
            CraftingComponent.AddRecipe(typeof(WainwrightTableObject), this);
        }
    }

    [Serialized]
    [RequireComponent(typeof(StandaloneAuthComponent))]
    [RequireComponent(typeof(VehicleComponent))]
    public partial class HandPloughObject : PhysicsWorldObject
    {
        private static Dictionary<Type, float> roadEfficiency = new Dictionary<Type, float>()
        {
            { typeof(DirtRoadBlock), 1 }, { typeof(DirtRoadWorldObjectBlock), 1 },
            { typeof(StoneRoadBlock), 1.2f }, { typeof(StoneRoadWorldObjectBlock), 1.2f },
            { typeof(AsphaltRoadBlock), 1.4f }, { typeof(AsphaltRoadWorldObjectBlock), 1.4f }
        };
        public override string FriendlyName { get { return "Hand Plough"; } }


        private HandPloughObject() { }

        protected override void Initialize()
        {
            base.Initialize();
            
            this.GetComponent<VehicleComponent>().Initialize(10, 1, roadEfficiency, 1);
            this.GetComponent<VehicleComponent>().HumanPowered(1);           
        }
    }
}