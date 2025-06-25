using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Script.Controllers
{
    public class EvenSceneIncome : MonoBehaviour
    {
        public Sprite groundSprite;
        private GameObject[] tiles;
        public Text text;

        void Start()
        {
            tiles = new GameObject[3];

            for (int i = 0; i < tiles.Length; i++)
            {
                GameObject tile = new GameObject("Ground" + i);
                SpriteRenderer sr = tile.AddComponent<SpriteRenderer>();
                sr.sprite = groundSprite;

                tile.transform.position = new Vector3(0f, i * 2f - 3, 0f);
                tile.transform.localScale = new Vector3(3f, 1f, 1f);
                tile.AddComponent<BoxCollider2D>();
                tile.tag = "GroundType2";
                tile.layer = LayerMask.NameToLayer("Default");
                tiles[i] = tile;
            }

        }


        void Update()
        {
            text.text = "Coin: " + MainModel.Money;
            for (int i = 0; i < tiles.Length; i++)
            {
                float ke = Mathf.Cos(Time.time * (i+1)) * 5f;
                float offset = Mathf.Sin(Time.time + i);
                tiles[i].transform.position = new Vector3(ke, i * 2f + offset * 0.1f - 3, 0f);
            }
        }

        public void OutGameIncome()
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
