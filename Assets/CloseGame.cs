using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(end());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(5f);
        print("ended");
        Application.Quit();
    }
}
