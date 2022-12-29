using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouvementScene2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    public GameObject panel;
    public Text ScoreText;
    public int score = 3;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "ballontn" || col.gameObject.name == "camel" || col.gameObject.name == "Chechia")
        {
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
            anim.SetBool("IsRunning", true);
            anim.SetBool("IsJumping", false);
        }
        if (Input.GetKeyDown("z"))
        {
            rb.velocity = Vector2.up * 10;
            anim.SetBool("IsJumping", true);

        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
            anim.SetBool("IsRunning", true);
            anim.SetBool("IsJumping", false);


        }
        if (Input.GetKeyUp("d"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsRunning", false);


        }
        if (score == 3)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }


    }


}
