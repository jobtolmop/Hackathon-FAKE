using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    public void ToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ToInstructions()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
