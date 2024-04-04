using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdeM.Controllers { 

    public class Character3D : EntityController
    {
        protected CharacterController _cc;
        protected float _gravity = -9.81f;
        protected Vector3 _velocity;
        protected Vector3 _direction;


        protected override void Awake()
        {
            base.Awake();
            _cc = gameObject.GetComponent<CharacterController>();

            if (_cc == null )
            {
                Debug.LogError("Debe tener el CharacterController attached");
            }

        }


        protected override void Update()
        {
            base.Update();
            _isGrounded = _cc.isGrounded;


            /* Velocity Y */
            _velocity.y += _gravity * Time.deltaTime;

            if (_isGrounded && _velocity.y < 0)
            {
                _velocity.y = -1.81f;
            }

            _cc.Move(_velocity);
        }
    }

}
