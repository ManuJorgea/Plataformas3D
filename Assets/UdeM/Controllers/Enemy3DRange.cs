using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdeM.Skills;

namespace UdeM.Controllers { 
    public class Enemy3DRange : Enemy3D
    {
        protected override void Start()
        {
            base.Start();
            _autoAttack = new RangeAutoAttack(
                10f,
                3f,
                Resources.Load<GameObject>("Bullet"),
                gameObject,
                1f
                );
        }
    }
}