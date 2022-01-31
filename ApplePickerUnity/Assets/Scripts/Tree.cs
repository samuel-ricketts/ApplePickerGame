/***
 * Created by: Sammy Ricketts
 * Date Created: 1/31/22
 * Last Edited: 1/31/22
 * Last Edited By: Sammy Ricketts
 * 
 * Description: Controls tree movement and apple spawning
 * ***/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection = 0.1f;
    public float secondBetweenAppleDrops = 1f;
    void Start()
    {
        Invoke("DropApple", 2f);

        



    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position; //move apple to tree pos
        Invoke("DropApple", secondBetweenAppleDrops);
    }
    // Update is called once per frame
    void Update()
    {
        //move every frame
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge) //move right
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)//move left
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; //change direction
        }
    }
}
