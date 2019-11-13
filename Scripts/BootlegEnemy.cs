using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootlegEnemy : MonoBehaviour
{
    public void Die()
    {
        if (gameObject.CompareTag("HealthBar"))
        {
            gameObject.GetComponent<HealthBar>().TakeDamage(2);
            print("yeet or be yeeted");
        }
        ScoreManager.instance.ChangeScore(-1);
        Destroy(gameObject);
    }
}
