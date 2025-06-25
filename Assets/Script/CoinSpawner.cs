using Assets.Script.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script
{
    public class CoinSpawner : MonoBehaviour
    {
        public Transform firePoint;
        public float fireSpeed = 5f;
        public float fireInterval = 1.5f;

        private float timer = 0f;

        void Update()
        {
            timer += Time.deltaTime;

            if (timer >= fireInterval)
            {
                FireCoin();
                timer = 0f;
            }
        }

        void FireCoin()
        {
            GameObject coin = CoinPool.Instance.GetCoin();
            coin.transform.position = firePoint.position;

            CoinController controller = coin.GetComponent<CoinController>();
            controller.Fire(Vector2.right + Vector2.up * 0.2f, fireSpeed);
        }
    }
}
