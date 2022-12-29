using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLevel1 : MonoBehaviour

{
    public GameObject panel;
    public Text ScoreText;
    public int score = 0;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "ballontn")
        {
            score++;
            ScoreText.text = score.ToString();
            Debug.Log(score);
        }
    }
    private void Update()
    {
        if (score == 3)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }

    }
}