using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{
    public GameObject timeDsiplay;
    public int seconds = 30;
    public bool deductingTime;

    // Update is called once per frame
    void Update()
    {
        // To be implemented when I have a high score scene
        /*if (seconds == 0)
        {
            seconds = 0;
            SceneManager.LoadScene();
        }
        else
        { */
            if (deductingTime == false)
            {
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
        // }

    }

    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDsiplay.gameObject.GetComponent<Text>().text = "TIME: " + seconds;
        deductingTime = false;
    }
}
