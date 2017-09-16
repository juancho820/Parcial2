using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Parcial2.Game
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]

    public class Bullet2 : MonoBehaviour
    {

        private Rigidbody myRigidBody;
        private float speed;
        private int damage;
        Enemy enemy;

        private GameObject instigator;

        public void SetParams(float bulletSpeed, int bulletDamage, GameObject instanceInstigator)
        {
            instigator = instanceInstigator;
            speed = bulletSpeed;
            damage = bulletDamage;
        }

        public void Toss()
        {
            myRigidBody.AddForce(transform.forward * speed, ForceMode.VelocityChange);
        }

        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.gameObject == Player.Instance.gameObject)
        //    {
        //        //Collided with player
        //    }
        //    else
        //    {
        //        Enemy enemy = other.GetComponent<Enemy>();

        //        if (enemy != null)
        //        {
        //            enemy.ReceiveDamage(damage);
        //        }
        //    }

        //    if (instigator != other.gameObject)
        //    {
        //        Destroy(gameObject);
        //    }
        //}

        // Use this for initialization
        private void Awake()
        {
            myRigidBody = GetComponent<Rigidbody>();
            Invoke("AutoDestroy", 0.05F);

            enemy = GetComponent<Enemy>();

        }

        public void OnDestroy()
        {
            instigator.GetComponent<Player>().myButton2.interactable = true;
            myRigidBody = null;
            RaycastHit hit;
            float distanceToObstacle = 0;
            if (Physics.SphereCast(this.transform.position,10, transform.forward, out hit, 10))
            {
                distanceToObstacle = hit.distance;
                if(hit.distance<10)
                {
                    enemy.ReceiveDamage(damage);
                }

            }
        }

        private void AutoDestroy()
        {
            Destroy(gameObject);
        }
    }
}