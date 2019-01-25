using DuckGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMod.src
{
    [EditorGroup("KzMod|Melee")]
    public class FighthingKnife: Sword
    {
        public FighthingKnife(float xpos, float ypos): base(xpos, ypos)
        {
            this._ammoType.range = 80f;
            this.graphic = new Sprite("sword", 0f, 3f);
            this.collisionSize = new Vec2(4f, 9f);
        }
    }
}
