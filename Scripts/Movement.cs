using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.position += Vector3.up * speed * Time.deltaTime;

        if (timer > 1)
        {
            speed = -speed;
            timer = 0;
            Destroy(gameObject,1);
        }
    }
}
