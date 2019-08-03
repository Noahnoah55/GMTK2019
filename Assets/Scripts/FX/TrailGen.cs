using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailGen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void drawtrail(List<Vector2> trail)
    {
        List<Vector3> vertecies = new List<Vector3>();
        foreach (Vector2 vertex in trail)
        {
            vertecies.Add(vertex);
        }
        Vector3[] line = vertecies.ToArray();
        GetComponent<LineRenderer>().positionCount = line.Length;
        GetComponent<LineRenderer>().SetPositions(line);
    }
}
