using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdeM.Controllers { 

    public class Character3DPlayer : Character3D {

        protected float _axisH;
        protected float _axisV;

        protected override void Update()
        {
            base.Update();

            _axisH = Input.GetAxis("Horizontal");
            _axisV = Input.GetAxis("Vertical");

            _direction = new Vector3(_axisH, 0, _axisV).normalized;
        }
    }
}