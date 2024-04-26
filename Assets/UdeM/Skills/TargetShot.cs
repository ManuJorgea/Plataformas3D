using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdeM.Skills {

    public class TargetShot : BaseSkill
    {
        protected GameObject _target;

        public TargetShot
            (string name,
            float coolDown,
            float atckDamage,
            float mgkDamage,
            float range) : base(name, coolDown, atckDamage, mgkDamage, range)
        {

            _target = null;
        }

        public GameObject Target
        {
            get { return _target; }
            set { _target = value; }
        }
    }
}
