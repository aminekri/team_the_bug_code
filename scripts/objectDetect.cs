using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectDetect : MonoBehaviour
{
    public int score = 0;
    public GameObject l;
    public GameObject m;
    public GameObject k;
    public GameObject s;
    public GameObject h;
    public GameObject panel2;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "lablabi-3")
        {
            l.SetActive(false);
        }
        if (col.gameObject.name == "kosksi")
        {
            k.SetActive(false);

        }
        if (col.gameObject.name == "slatamechwiya")
        {
            s.SetActive(false);
        }
        if (col.gameObject.name == "mloukhiya")
        {
            m.SetActive(false);
        }
        if (col.gameObject.name == "harissa")
        {
            h.SetActive(false);
        }
        if(col.gameObject.name == "lablabi-3"|| col.gameObject.name == "kosksi" || col.gameObject.name == "slatamechwiya" || col.gameObject.name == "mloukiya" || col.gameObject.name == "harissa")
        {
            panel2.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
