using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bridy : MonoBehaviour
{
    public bool isDead = false;
    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager gameManager;
    public GameObject DeathScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //týklamayý alýr
        if (Input.GetMouseButtonDown(0))
        {
            //havada kuþu sýçratýr
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            gameManager.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
            if(Input.GetMouseButtonDown(0))
            {
                gameManager.RestartGame();
            }
        }
    }
}
