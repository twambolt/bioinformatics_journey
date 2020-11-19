using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizControllerScripts : MonoBehaviour
{
    public int currentQuestion;
    public int score;

    public ComputerController computerController;

    public GameObject nextButton;
    public GameObject submitButton;
    public GameObject dropDown;

    public GameObject Results;
    public TextMeshProUGUI scoreText;
    public GameObject completeModuleButton;

    public GameObject Question1;
    public TextMeshProUGUI A1;
    public GameObject Question2;
    public TextMeshProUGUI A2;
    public GameObject Question3;
    public TextMeshProUGUI A3;
    public GameObject Question4;
    public TextMeshProUGUI A4;
    public GameObject Question5;
    public TextMeshProUGUI A5;
    public GameObject Question6;
    public TextMeshProUGUI A6;
    public GameObject Question7;
    public TextMeshProUGUI A7;
    public GameObject Question8;
    public TextMeshProUGUI A8;
    public GameObject Question9;
    public TextMeshProUGUI A9;
    public GameObject Question10;
    public TextMeshProUGUI A10;

    public TextMeshProUGUI sample;

    public int answerSelect;
    private Color32 ogColor;
    
    // Start is called before the first frame update
    void Start()
    {
        currentQuestion = 1;
        answerSelect = 0;
        score = 0;
        Question1.SetActive(true);
        nextButton.SetActive(false);
        ogColor = sample.color;
    }

    public void Reset()
    {
        currentQuestion = 1;
        answerSelect = 0;
        score = 0;
        Question1.SetActive(true);
        nextButton.SetActive(false);
        dropDown.SetActive(true);
        submitButton.SetActive(true);
        Results.SetActive(false);
    }

    public void CompleteModuleButton()
    {
        computerController.QuizHome.SetActive(false);
        computerController.completed[3] = true;
        computerController.RecalcCompleted();
        computerController.computerHome.SetActive(true);
    }

    public void AnswerButton()
    {
        switch (currentQuestion)
        {
            case 1:
                if (answerSelect == 0)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A1.color = new Color32(0, 190, 70, 255);
                break;
            case 2:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A2.color = new Color32(0, 190, 70, 255);
                break;
            case 3:
                if (answerSelect == 0)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A3.color = new Color32(0, 190, 70, 255);
                break;
            case 4:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A4.color = new Color32(0, 190, 70, 255);
                break;
            case 5:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A5.color = new Color32(0, 190, 70, 255);
                break;
            case 6:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A6.color = new Color32(0, 190, 70, 255);
                break;
            case 7:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A7.color = new Color32(0, 190, 70, 255);
                break;
            case 8:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A8.color = new Color32(0, 190, 70, 255);
                break;
            case 9:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A9.color = new Color32(0, 190, 70, 255);
                break;
            case 10:
                if (answerSelect == 1)
                    score++;
                // maybe add a good sound and bad sound
                nextButton.SetActive(true);
                A10.color = new Color32(0, 190, 70, 255);
                break;
            default:
                Debug.Log("Error fell out of answer");
                break;
        }
    }

    public void NextButton()
    {
        switch (currentQuestion)
        {
            case 1:
                Question1.SetActive(false);
                Question2.SetActive(true);
                A1.color = ogColor;
                break;
            case 2:
                Question2.SetActive(false);
                Question3.SetActive(true);
                A2.color = ogColor;
                break;
            case 3:
                Question3.SetActive(false);
                Question4.SetActive(true);
                A3.color = ogColor;
                break;
            case 4:
                Question4.SetActive(false);
                Question5.SetActive(true);
                A4.color = ogColor;
                break;
            case 5:
                Question5.SetActive(false);
                Question6.SetActive(true);
                A5.color = ogColor;
                break;
            case 6:
                Question6.SetActive(false);
                Question7.SetActive(true);
                A6.color = ogColor;
                break;
            case 7:
                Question7.SetActive(false);
                Question8.SetActive(true);
                A7.color = ogColor;
                break;
            case 8:
                Question8.SetActive(false);
                Question9.SetActive(true);
                A8.color = ogColor;
                break;
            case 9:
                Question9.SetActive(false);
                Question10.SetActive(true);
                A9.color = ogColor;
                break;
            case 10:
                Question10.SetActive(false);
                dropDown.SetActive(false);
                A10.color = ogColor;
                submitButton.SetActive(false);
                SetScoreText();
                Results.SetActive(true);
                completeModuleButton.SetActive(true);
                break;
            default:
                Debug.Log("Error, fell out of questions");
                break;
        }
        nextButton.SetActive(false);
        currentQuestion++;
    }

    public void SetScoreText()
    {
        if (score >= 7)
        {
            scoreText.text = string.Format("Wow! Way to go! You scored {0}/10 on the test!", score);
        }
        else if (score < 7 && score >= 4)
        {
            scoreText.text = string.Format("You scored {0}/10 on the test!", score);
        }
        else
        {
            scoreText.text = string.Format("You should play again. You scored {0}/10 on the test :.(", score);
        }
    }


    public void HandleInputAnswer(int val)
    {
        answerSelect = val;
    }
}
