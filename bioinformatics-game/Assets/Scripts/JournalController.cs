using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalController : MonoBehaviour
{
    public bool isJournalOpen;
    public GameObject journal;
    public GameObject playerUI;
    public PlayerController player;

    public GameObject animalEntries;
    public GameObject animalTable;
    public PauseManager pauseManager;

    // Start is called before the first frame update
    void Start()
    {
        animalEntries.SetActive(true);
        animalTable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j") && !pauseManager.paused)
        {
            isJournalOpen = !isJournalOpen;
            //playerUI.SetActive(!isJournalOpen);
            journal.SetActive(isJournalOpen);
            player.canMove = !player.canMove;
            player.anim.SetBool("Run", player.canMove);
        }   
    }

    public void BackButtonJournal()
    {
        animalTable.SetActive(false);
        animalEntries.SetActive(true);
    }

    public void NextButtonJournal()
    {
        animalEntries.SetActive(false);
        animalTable.SetActive(true);
    }
}
