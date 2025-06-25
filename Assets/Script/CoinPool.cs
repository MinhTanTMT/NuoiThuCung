using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script
{
    public class CoinPool : MonoBehaviour
    {
        public GameObject coinPrefab;
        public int poolSize = 10;

        private List<GameObject> pool = new List<GameObject>();

        public static CoinPool Instance;

        void Awake()
        {
            Instance = this;

            for (int i = 0; i < poolSize; i++)
            {
                GameObject coin = Instantiate(coinPrefab);
                coin.SetActive(false);
                pool.Add(coin);
            }
        }

        public GameObject GetCoin()
        {
            foreach (var coin in pool)
            {
                if (!coin.activeInHierarchy)
                {
                    coin.SetActive(true);
                    return coin;
                }
            }

            GameObject newCoin = Instantiate(coinPrefab);
            newCoin.SetActive(true);
            pool.Add(newCoin);
            return newCoin;
        }
    }
}
