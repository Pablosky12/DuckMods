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
            this.infinite = true;
        }

        public override void Fire()
        {
        }

        public override void OnReleaseAction()
        {
            base.OnReleaseAction();
            if (this.ammo > 0) this.ammo--;
            if (isServerForObject)
            {
                Mine mine = new Mine(0,0);
                mine.position = Offset(this._barrelOffsetTL);
                mine.vSpeed = this.barrelVector.y * 6f;
                mine.hSpeed = this.barrelVector.x * 6f;
                mine.Thrown();
                Level.Add(mine);
            }
            base.OnPressAction();
        }
    }

    public class ThrowableMine: ATGrenade
    {

    }
}
