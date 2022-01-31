/***
 * Created by: Sammy Ricketts
 * Date Created: 1/31/22
 * Last Edited: 1/31/22
 * Last Edited By: Sammy Ricketts
 * 
 * Description: Apple despawn logic
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
