using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]Transform player;
    Vector3 cameraVelocity;
    [SerializeField] float smoothTime = 1;
    [SerializeField] bool lookAtPlayer;
    [SerializeField] int lowerLimit = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        if(player.position.y > lowerLimit)
        {
            Vector3 targetPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraVelocity, smoothTime);
            if(lookAtPlayer == true)
            {
                transform.LookAt(player);
            }            
        }
    }
}
