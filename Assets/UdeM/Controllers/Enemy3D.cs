using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdeM.Skills;

namespace UdeM.Controllers { 

    public class Enemy3D : NPC3D
    {
        [SerializeField] protected bool _isExecutingAttck;
        protected AutoAttack _autoAttack;

        protected override void Awake()
        {
            base.Awake();
            _isAgro = true;
            _speed = 5f;
        }

        protected override void Start()
        {
            base.Start();
            _autoAttack = new AutoAttack(10f, 3f);
        }

        protected override void Update() {
            base.Update();

            if (_isAttacking)
            {
                if (!_isExecutingAttck)
                {
                    _navigator.destination = _target.transform.position;
                }
                if (_navigator.remainingDistance <= _autoAttack.Range)
                {
                    _navigator.speed = 0;
                    _navigator.destination = transform.position;
                    _isExecutingAttck = true;
                    _autoAttack.Target = _target.GetComponent<Damageable>();
                    Atack(_autoAttack);

                }else
                {
                    _navigator.speed = _speed;
                }
                
            }
        }

        protected void OnTriggerEnter(Collider collider)
        {
            if(collider.gameObject == _target)
            {
                _isAttacking = true;            
            }
        }

        protected void OnTriggerExit(Collider collider)
        {
            if (collider.gameObject == _target)
            {
                _isAttacking = false;
            }
        }
    }
}