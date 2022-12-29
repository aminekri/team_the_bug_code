using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youin : MonoBehaviour
{
    public GameObject panel1;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            panel1.SetActive(true);
            Time.timeScale = 0;

        }
    }
}