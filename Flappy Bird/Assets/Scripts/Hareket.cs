using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private void Start()
    {
        Destroy(gameObject,8);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
 
    }
}
