using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    [Range(0, 1)]
    public float smoothing;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 target = new Vector3(player.position.x, player.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, target, smoothing);
    }
}
