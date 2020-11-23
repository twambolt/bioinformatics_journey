using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : MonoBehaviour
{
    public PlayerController player;


    public GameObject interactTip;
    
    public GameObject playerUI;
    public GameObject computerHome;
    public GameObject MorphPhyloDisplayHome;
    public GameObject BuildMorphPhyloDisplay;
    public GameObject HypMorphDisplay;
    public GameObject QuizHome;

    public GameObject QuizButton;
    public GameObject FinishText;


    public bool inComputerRange;
    public GameObject[] computerPages;

    public GameManager gameManager;

    public bool[] completed = new bool[4];
    private bool done;
    public int dataSelect;
    public int algSelect;


    // Start is called before the first frame update
    void Start()
    {
        dataSelect = 0;
        algSelect = 0;
        done = false;
        inComputerRange = false;
        computerPages = GameObject.FindGameObjectsWithTag("CompUI");
        completed[0] = false; // Build Morph
        completed[1] = false; // DNA 
        completed[2] = false; // AA
        completed[3] = false; // Quiz
    }

    // Update is called once per frame
    void Update()
    {
        if (inComputerRange)
        {
            StartComputer();
            QuitComputer();
        }
    }

    void StartComputer()
    {
        if (inComputerRange && Input.GetKeyDown("f") && gameManager.numAnimalsFound == 12)
        {
            player.isOccupied = true;
            player.canMove = false;
            playerUI.SetActive(false);
            computerHome.SetActive(true);
        }
    }

    void QuitComputer()
    {
        if (inComputerRange && Input.GetKeyDown("escape") && done)
        {
            foreach (GameObject page in computerPages)
                page.SetActive(false); // not working 100%

            //player.isOccupied = false;
            player.canMove = true;
            computerHome.SetActive(false);
            playerUI.SetActive(true);
        }
    }

    public void RecalcCompleted()
    {
        int count = 0;
        gameManager.audioFeedBack.PlayModuleCompleted();
        for (int i = 0; i < completed.Length; i++)
        {
            if (completed[i])
            {
                count++;
            }
        }
        if (count == 3)
        {
            QuizButton.SetActive(true);
        }
        if (count == 4)
        {
            FinishText.SetActive(true);
            done = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        interactTip.SetActive(true);
        inComputerRange = true;

    }

    public void OnTriggerExit(Collider other)
    {
        interactTip.SetActive(false);
        inComputerRange = false;
    }


    public void HandleDataChange(int value)
    {
        dataSelect = value;
    }

    public void HandleAlgChange(int value)
    {
        algSelect = value;
    }

}
