using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBoxes : MonoBehaviour
{
    // reference to our scoring class
    public Scoring score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // For now, no boxes so we just add a score when P is pushed
        if(Input.GetKeyDown(KeyCode.P))
        {
            score.AddScore(1);
        }

    }
}
