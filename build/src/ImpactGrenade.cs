using DuckGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMod.src
{
    [EditorGroup("KzMod|Weapons")]
    public class ImpactGrenade: Grenade
    {
        public ImpactGrenade(float xpos, float ypos) : base(xpos, ypos)
        {

        }

        public override void OnImpact(MaterialThing with, ImpactedFrom from)
        {
            if (!this._pin && with is Duck)
            {
                this._timer = 0.01f;
            }
        }

    }
}
