// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Serialization;

    [Serialized]
    [Weight(15000)]  
    public class WoodenElevatorItem : WorldObjectItem<WoodenElevatorObject>
    {
        public override string FriendlyName         { get { return "Wooden Elevator"; } }
        public override string Description          { get { return "Small elevator for hauling minimal loads."; } }
    }

    [Serialized]
    [RequireComponent(typeof(StandaloneAuthComponent))] 
    public class WoodenElevatorObject : PhysicsWorldObject
    {
        public override string FriendlyName { get { return "Wooden Elevator"; } }

        [Serialized] private float cagePos;
        private float cageVelocity = 0f;

        private WoodenElevatorObject() { }

        protected override void Initialize()
        {
            base.Initialize();
            this.SetAnimatedState("dir", 0f);
        }

        public override void Tick()
        {
            base.Tick();
        }

        public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer)
        {
            base.SendInitialState(bsonObj, viewer);
            this.SendUpdate(bsonObj, viewer);
            bsonObj["dir"] = this.GetAnimatedState<float>("dir");
        }

        public override void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer)
        {
            base.SendUpdate(bsonObj, viewer);
            var cage = BSONObject.New;
            cage["pos"] = new Vector3(0f, this.cagePos, 0f);
            cage["v"] = new Vector3(0f, this.cageVelocity, 0f);
            bsonObj["cage"] = cage;
        }

        public override void ReceiveUpdate(BSONObject bsonObj)
        {
            base.ReceiveUpdate(bsonObj);
            if (bsonObj.ContainsKey("cage"))
            {
                var cagebson = bsonObj["cage"].ObjectValue;
                this.cagePos = cagebson["pos"].Vector3Value.y;
                this.cageVelocity = cagebson["v"].Vector3Value.y;
            }

            if (bsonObj.ContainsKey("stop"))
            {
                this.cageVelocity = 0f;
                this.SetAnimatedState("dir", 0f);
            }
        }

        public override InteractResult OnActInteract(InteractionContext context)
        {
            if (context.Parameters != null && context.Parameters.ContainsKey("Down"))
            {
                var physicsEntity = this.netEntity as NetPhysicsEntity;
                physicsEntity.SetPhysicsController(context.Player);
                this.AnimatedStates["dir"] = -1f;
            }
            else if (context.Parameters != null && context.Parameters.ContainsKey("Up"))
            {
                var physicsEntity = this.netEntity as NetPhysicsEntity;
                physicsEntity.SetPhysicsController(context.Player);
                this.AnimatedStates["dir"] = 1f;
            }
            return base.OnActInteract(context);
        }
    }
}