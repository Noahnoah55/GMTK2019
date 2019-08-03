using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject TrailObj;
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
        List<Vector2> trail = new List<Vector2>();
        Vector2 bulletPosition = new Vector2(transform.position.x, transform.position.y);
        int currentDistance = 0;
        //Code to track the bullet (runs all in one frame)
        while (true)
        {
            trail.Add(bulletPosition);
            print(trail);
            print(bulletPosition);
            // Check the space to see if any switches are in the bullet's path
            // If so, inform the switch's script and let it do it's thing
            //!= true big gay inverse
            if (TileMover.checkSpace(bulletPosition + direction,"Switch") != true)
            {
                List<Collider2D> colliders = TileMover.getCollidersWithTag(bulletPosition+direction,"Switch");
                foreach (Collider2D collider in colliders)
                {
                    collider.GetComponent<Switch>().hitSwitch();
                }
            }

            if (TileMover.checkSpace(bulletPosition + direction,"Enemy") != true)
            {
                List<Collider2D> colliders = TileMover.getCollidersWithTag(bulletPosition+direction,"Enemy");
                print("ded1");
                foreach (Collider2D collider in colliders)
                {
                    collider.GetComponent<Enemy>().die(); // When you shoot enemy, he die
                    print("ded");
                }
            }

            if (TileMover.checkSpace(bulletPosition + direction, "CurveRightUp") != true)
            {
                List<Collider2D> colliders = TileMover.getCollidersWithTag(bulletPosition + direction, "CurveRightUp");
                if (direction == Vector2.right)
                {
                    bulletPosition += direction;
                    direction = Vector2.up;
                    trail.Add(bulletPosition);
                }
                else if (direction == Vector2.down)
                {
                    bulletPosition += direction;
                    direction = Vector2.left;
                    trail.Add(bulletPosition);
                }
            }
            if (TileMover.checkSpace(bulletPosition + direction, "CurveRightDown") != true)
            {
                List<Collider2D> colliders = TileMover.getCollidersWithTag(bulletPosition + direction, "CurveRightDown");
                if (direction == Vector2.right)
                {
                    bulletPosition += direction;
                    direction = Vector2.down;
                    trail.Add(bulletPosition);
                }
                else if (direction == Vector2.up)
                {
                    bulletPosition += direction;
                    direction = Vector2.left;
                    trail.Add(bulletPosition);
                }
            }
            if (TileMover.checkSpace(bulletPosition + direction, "CurveLeftUp") != true)
            {
                List<Collider2D> colliders = TileMover.getCollidersWithTag(bulletPosition + direction, "CurveLeftUp");
                if (direction == Vector2.left)
                {
                    bulletPosition += direction;
                    direction = Vector2.up;
                    trail.Add(bulletPosition);
                }
                else if (direction == Vector2.down)
                {
                    bulletPosition += direction;
                    direction = Vector2.right;
                    trail.Add(bulletPosition);
                }
            }
            if (TileMover.checkSpace(bulletPosition + direction, "CurveLeftDown") != true)
            {
                List<Collider2D> colliders = TileMover.getCollidersWithTag(bulletPosition + direction, "CurveLeftDown");
                if (direction == Vector2.left)
                {
                    bulletPosition += direction;
                    direction = Vector2.down;
                    trail.Add(bulletPosition);
                }
                else if (direction == Vector2.up)
                {
                    bulletPosition += direction;
                    direction = Vector2.right;
                    trail.Add(bulletPosition);
                }
            }

            // Make sure the bullet isn't going to go through a wall
            // Runs after interactibles so that switches/enemies next to a wall don't die
            // Also allows switches and enemies to function as bullet blockers
            if (TileMover.checkSpace(bulletPosition + direction,"BulletBlocker")) 
            {
                bulletPosition += direction;
            }
            else
            {
                break;
            }

            // Failsafe to make sure the loop ends eventually
            currentDistance += 1;
            if (currentDistance > maxDistance) {print("Hit Max Distance"); break;}
        }
        hiteffect(direction,bulletPosition,trail);
    }
    public void hiteffect(Vector2 direction, Vector2 bulletPosition, List<Vector2> trail)
    {
        Destroy(Instantiate(Boom, new Vector3(bulletPosition.x, bulletPosition.y, -2), Quaternion.identity),1f);
        GameObject tempTrailObj = Instantiate(TrailObj,Vector3.zero,Quaternion.identity);
        tempTrailObj.GetComponent<TrailGen>().drawtrail(trail);
        Destroy(tempTrailObj,1f);
    }
}
