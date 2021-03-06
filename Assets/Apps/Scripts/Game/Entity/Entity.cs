using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SpaceInvader.Game {
    public enum EntityType { 
        Player, Enemy, Barrier
    }
    public abstract class Entity : MonoBehaviour {
        public abstract EntityType EntityType { get; }
        public Health health;
        //public int hp;
        public float speed;
        public Vector3 deltaPosition;
        public List<EntityType> targets;

        public event Action<int> onDamaged;
        public event Action<Entity> onDead;
        public Action<Vector3> onSetDirection;

        protected Entity() {
            health = new Health(1);
        }

        private void LifeCheck() {
            if (health.value == 0) {
                onDead?.Invoke(this);
            }
        }

        public void Damaged(int _damage) {
            health.Reduce(_damage);
            onDamaged?.Invoke(_damage);

            LifeCheck();
        }

        public void SetDeltaPosition (Vector3 _newPosition) {
            deltaPosition = _newPosition - transform.position;
        }
    } 
}
