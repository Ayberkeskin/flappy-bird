using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Birdy BirdScript;
    public GameObject Borular;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
        
    }


    public IEnumerator SpawnObject(float time)
      {
           while (BirdScript.isDead == false) 
                  { 
                    Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
                    yield return new WaitForSeconds(time);
                  }            
      }
}

/* Borularý spawn etmek için baþka bir yöntem yukaruya float timer eklemen lazým
private void Update()
{
    while (BirdScript.isDead == false) 
    {
        timer += Time.deltaTime;
    if (timer>2)
    {
        Borular = Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0),transform.rotation)as GameObject;
        timer = 0;
    }
    }

}*/
