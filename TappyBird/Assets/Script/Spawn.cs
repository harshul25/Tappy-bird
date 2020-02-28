using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
     StartCoroutine(Example());
   
    }
    IEnumerator Example () {
     while(true){ // This creates a never-ending loop
         yield return new WaitForSeconds(3);
         // Do stuff here
         Instantiate(myPrefab, new Vector3(11,Random.Range(-1.5f, 2.5f), 0), Quaternion.identity);
         // If you want to stop the loop, use: break;
     }
 
 
 }
    
}