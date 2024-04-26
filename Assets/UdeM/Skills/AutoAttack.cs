using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdeM.Skills { 
    public class AutoAttack : TargetShot
    {
        public AutoAttack(float actkDamage, float range) :
        base("AutoAttack", 1f, actkDamage, 0, range)
        {
        
        }
    }
}