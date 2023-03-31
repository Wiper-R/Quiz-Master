using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float timetoCompleteQuestion = 30f;
    [SerializeField]
    float timeToShowCorrectAnswer = 10f;
    public bool loadNextQuestion = false;
    public float fillFraction;
    public bool isAnsweringQuestion = false;
    float timerValue = 0;
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer(){
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timetoCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timetoCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
