using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour {

    public float moveSpeed;
    public float oldPosition;
    public float minY;
    public float maxY;

    

    private GameObject obj;
    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        moveSpeed = 2;
        oldPosition = 13;        
        minY = -1;
        maxY = 1;

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wall");
        if (other.gameObject.tag.Equals("ResetWall"))
        {
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY + 1), 0);
        }
    }

}
