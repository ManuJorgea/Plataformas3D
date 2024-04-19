using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdeM.Controllers { 

    public class Enemy3D : NPC3D
    {
        [SerializeField] protected GameObject _target;

        protected override void Update() {
            base.Update();

            _navigator.destination = _target.transform.position;
        }

    }
}