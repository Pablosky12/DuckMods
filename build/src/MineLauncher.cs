using DuckGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMod.src
{
    [EditorGroup("guns|explosives")]
    public class MineLauncher : GrenadeLauncher
    {
        public MineLauncher(float xval, float yval) : base(xval, yval)
        {
            this.ammo = 3;
            this.physicsMaterial = PhysicsMaterial.Metal;
        }

        public override void Fire()
        {
        }

        public override void OnReleaseAction()
        {
            base.OnReleaseAction();
            if (this.ammo > 0 && isServerForObject)
            {
                this.ammo--;
                Vec2 offset = this.Offset(this.barrelOffset);
                ThrowableMine mine = new ThrowableMine(offset.x, offset.y);
                mine.position = offset;
                mine.vSpeed = this.barrelVector.y * 7f;
                mine.hSpeed = this.barrelVector.x * 7f;
                mine._pin = false;
                mine.UpdatePinState();
                mine.Arm();
                this.Fondle((Thing)mine);
                this.kick = 3f;
                this.ApplyKick();
                Level.Add(mine);
            }
        }
    }

    public class ThrowableMine : Mine
    {
        public ThrowableMine(float xval, float yval) : base(xval, yval)
        {
        }
        public override void Update()
        {
            this._bouncy = 0.2f;
            this.gravMultiplier = 0.8f;
            this.frictionMult = 0.4f;
            base.Update();
        }
    }
}
