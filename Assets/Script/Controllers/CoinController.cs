using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Controllers
{
    public class CoinController : MonoBehaviour
    {
        private Rigidbody2D rb;
        private AudioSource audioSource;

        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            audioSource = GetComponent<AudioSource>();
        }

        public void Fire(Vector2 direction, float speed)
        {
            rb.velocity = direction * speed;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                MainModel.Money += 1;

                if (audioSource != null)
                {
                    audioSource.Play();
                }
                Invoke(nameof(Hide), 0.2f);
            }
            else if (collision.collider.CompareTag("Ground"))
            {
                Invoke(nameof(Hide), 0.2f);
            }
        }

        private void Hide()
        {
            this.gameObject.SetActive(false);
        }

        void OnDisable()
        {
            rb.velocity = Vector2.zero;
        }
    }
}
