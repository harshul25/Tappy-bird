using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public Transform trans;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,15);
    }

    // Update is called once per frame
    void Update()
    {
        trans.Translate(-1 * 2 * Time.deltaTime,0,0);
    }

}
