using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Boom;
    public int maxDistance = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fireShot(Vector2 direction)
    {
        Vector2 bulletPosition = new Vector2(transform.position.x, transform.position.y);
        int currentDistance = 0;
        while (true)
        {
            if (TileMover.checkSpace(bulletPosition + direction,"BulletBlocker")) 
            {
                bulletPosition += direction;
            }
            else
            {
                print ($"Hit a wall at {bulletPosition}");
                Instantiate(Boom,new Vector3(bulletPosition.x,bulletPosition.y,-2),Quaternion.identity);
                break;
            }
            currentDistance += 1;
            if (currentDistance > maxDistance) {print("Hit Max Distance"); break;}
        }
    }
}
