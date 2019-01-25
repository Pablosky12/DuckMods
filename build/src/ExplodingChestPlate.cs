using DuckGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMod.src
{
    [EditorGroup("KzMod|Armors")]
    public class ExplodingChestPlate : ChestPlate
    {
        public ExplodingChestPlate(float xpos, float ypos) : base(xpos, ypos) { }
        public override bool Destroy(DestroyType type = null)
        {
            AmmoType gun = new ATShrapnel();
            gun.FireBullet(new Vec2(x, y));
            //Level.Remove(gun);
            return base.Destroy(type);
        }
    }

    [EditorGroup("KzMod|Weapons")]
    public class DuelingShotgun : DuelingPistol
    {
        public DuelingShotgun(float xpos, float ypos) : base(xpos, ypos)
        {
            this._ammoType = new ATShotgun();
            //this._
        }
    }
}
