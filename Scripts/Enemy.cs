using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Die()
    {
        ScoreManager.instance.ChangeScore(1);
        Destroy(gameObject);
    }
}
