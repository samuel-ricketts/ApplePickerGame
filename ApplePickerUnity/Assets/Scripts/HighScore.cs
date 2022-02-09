/***
 * Created by: Sammy Ricketts
 * Date Created: 2/8/22
 * Last Edited: 2/8/22
 * Last Edited By: Sammy Ricketts
 * 
 * Description: High Score editor
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
        if (score > PlayerPrefs.GetInt("High Score"))
        { 
            PlayerPrefs.SetInt("High Score", score);
        }

    }




    void Awake()
    { 
      
        if (PlayerPrefs.HasKey("High Score"))
        { 
            score = PlayerPrefs.GetInt("High Score");
        }
        
        PlayerPrefs.SetInt("High Score", score); 
    }

}
