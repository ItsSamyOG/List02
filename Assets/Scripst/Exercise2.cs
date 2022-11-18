using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    //Time.
    public float timeCounter;
    //Start time.
    private float initialTime; 


    public TextMeshProUGUI timeText;
    public Image timeImage;

    private bool startClick = true;

    // Starts the counter
    void Update()
    {
        if (timeCounter > 0 && startClick == false)
        {
            UpdateTime();
        }
    }

    //Wen we click de botton the image starts
    public void StartButton()
    {
        initialTime = timeCounter;
        timeText.text = timeCounter.ToString();
        startClick = false;
    }

    //Wen we click de botton the image starts to foll down
    public void UpdateTime()
    {
        timeCounter -= Time.deltaTime;
        timeText.text = Mathf.Round(timeCounter).ToString();        
        timeImage.fillAmount = timeCounter / initialTime; 
    }

    
   
    
}
