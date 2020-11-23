using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public PlayerController player;
    public bool playerOccupied;
    public int numAnimalsFound;
    public bool[] animalsCollected = new bool[12];
    public TextMeshProUGUI animalProg;

    public GameObject ani1;
    public GameObject ani2;
    public GameObject ani3;
    public GameObject ani4;
    public GameObject ani5;
    public GameObject ani6;
    public GameObject ani7;
    public GameObject ani8;
    public GameObject ani9;
    public GameObject ani10;
    public GameObject ani11;
    public GameObject ani12;

    public GameObject nextButton;

    public AudioFeedbackScripts audioFeedBack;
    // Start is called before the first frame update
    void Start()
    {
        playerOccupied = false;
        InstantiateAnimalList();
        numAnimalsFound = 0;
        RecalcFoundAnimals();
    }

    // Update is called once per frame
    void Update()
    {
        ProfessorCheatCodes();
    }

    public void InstantiateAnimalList()
    {
        for (int i = 0; i < animalsCollected.Length; i++)
        {
            animalsCollected[i] = false;
        }
    }

    public void RecalcFoundAnimals()
    {
        int count = 0;
        for (int i = 0; i < animalsCollected.Length; i++)
        {
            if (animalsCollected[i] == true)
                count += 1;
        }
        if (count != numAnimalsFound)
            audioFeedBack.PlayAnimalCollected();
        numAnimalsFound = count;
        animalProg.text = string.Format("Collect animal samples ({0}/12 found)", numAnimalsFound);

        if (numAnimalsFound == 12)
        {
            animalProg.color = new Color32(0, 190, 70, 255);
            nextButton.SetActive(true);
        }
    }

    public void ProfessorCheatCodes()
    {
        if (Input.GetKeyDown("f") && Input.GetKeyDown("escape") && Input.GetKeyDown("space"))
        {
            for (int i = 0; i < animalsCollected.Length; i++)
            {
                animalsCollected[i] = true;
            }
            RecalcFoundAnimals();
            CheatJournal();
        }
    }

    public void CheatJournal()
    {
        ani1.SetActive(true);
        ani2.SetActive(true);
        ani3.SetActive(true);
        ani4.SetActive(true);
        ani5.SetActive(true);
        ani6.SetActive(true);
        ani7.SetActive(true);
        ani8.SetActive(true);
        ani9.SetActive(true);
        ani10.SetActive(true);
        ani11.SetActive(true);
        ani12.SetActive(true);
    }
}
