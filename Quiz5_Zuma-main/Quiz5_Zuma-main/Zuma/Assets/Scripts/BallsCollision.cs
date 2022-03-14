using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCollision : MonoBehaviour
{
    // same colour  collision 
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag.Equals(collision.gameObject.tag) && gameObject.GetComponent<BallsCollision>().enabled)
        {
            collision.gameObject.GetComponent<BallsCollision>().enabled = true;
            Destroy(gameObject);
        }
    }
}
