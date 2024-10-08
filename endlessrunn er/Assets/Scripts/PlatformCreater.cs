using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreater : MonoBehaviour
{
    public GameObject[] platformPrefab;
    public Transform referencePoint;
    [SerializeField] GameObject lastCreatedPlatform;
    public float spaceBetweenPlatforms = 2;
    float lastPlatformWidth;
   

    // Update is called once per frame
    void Update()
    {
        if (lastCreatedPlatform.transform.position.x <referencePoint.position.x)
        {
            Vector3 targetCreationPoint = new Vector3(referencePoint.position.x + lastPlatformWidth+spaceBetweenPlatforms, 0, 0);
            int randomPlatfrom = Random.Range(0,3);
            lastCreatedPlatform = Instantiate(platformPrefab[randomPlatfrom], targetCreationPoint, Quaternion.identity);
            BoxCollider2D collider = lastCreatedPlatform.GetComponent<BoxCollider2D>();
            lastPlatformWidth = collider.bounds.size.x;
        }
    }
}
