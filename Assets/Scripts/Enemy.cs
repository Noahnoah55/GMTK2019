using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject remains;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void die()
    {
        Instantiate(remains,transform.position,Quaternion.identity);
        Destroy(this.gameObject);
    }
}
