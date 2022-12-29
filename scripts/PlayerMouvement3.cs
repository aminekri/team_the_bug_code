using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMouvement3 : MonoBehaviour
{
    public int score = 0;
    public GameObject l;
    public GameObject m;
    public GameObject k;
    public GameObject s;
    public GameObject h;
    public GameObject panel2;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    public Text ScoreText;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "lablabi-3")
        {
            l.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
        if (col.gameObject.name == "kosksi")
        {
            k.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
        if (col.gameObject.name == "slatamechwiya")
        {
            s.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
        if (col.gameObject.name == "mloukhiya")
        {
            m.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
        if (col.gameObject.name == "harissa")
        {
            h.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
        if (score == 5)
        {
            panel2.SetActive(true);


        }
    }
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
        if (score == 5)
        {
            panel2.SetActive(true);
            Time.timeScale = 0;
        }


    }
}
