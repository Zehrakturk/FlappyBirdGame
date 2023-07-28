using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Bridy birdScript;
    public GameObject Engeller;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while(!birdScript.isDead)
        {
            Instantiate(Engeller, new Vector3(3, Random.Range(-height,height),0 ), Quaternion.identity) ;
            yield return new WaitForSeconds(time);

        }
    }
}
