/***
 * Created by: Sammy Ricketts
 * Date Created: 2/8/22
 * Last Edited: 2/8/22
 * Last Edited By: Sammy Ricketts
 * 
 * Description: Basket Code
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {

        GameObject scoreGO = GameObject.Find("Score Counter");

        scoreGT = scoreGO.GetComponent<Text>();

        scoreGT.text = "0";


    }

    void Update()
    {

        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);


        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

       

        }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);

            score += 100;

            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }








    }
}
