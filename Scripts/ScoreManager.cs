using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text text;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameManager.instance.score;
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "You Whacked " + score.ToString() + " Moles";
        GameManager.instance.score = score;
    }

    //gedoe
    public void Update()
    {
        if (score >= 5)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (score >= 10)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        if (score >= 20)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        if (score >= 35)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        if (score >= 50)
        {
            transform.GetChild(4).gameObject.SetActive(true);
        }

    }
}