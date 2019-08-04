using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float lerpt = .05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lerpedpos = Vector3.Lerp(transform.position,player.transform.position,lerpt);
        lerpedpos.z = transform.position.z;
        transform.position = lerpedpos;
    }
}
