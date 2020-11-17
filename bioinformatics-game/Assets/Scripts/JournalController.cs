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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j") && !player.isOccupied)
        {
            isJournalOpen = !isJournalOpen;
            playerUI.SetActive(!isJournalOpen);
            journal.SetActive(isJournalOpen);
            player.canMove = !player.canMove;
            player.anim.SetBool("Run", player.canMove);
        }   
    }
}
