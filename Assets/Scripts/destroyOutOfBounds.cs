using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }
}
