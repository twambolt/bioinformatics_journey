using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PlayerController player;

    public bool playerOccupied;


    public List<string> samples;

    // Start is called before the first frame update
    void Start()
    {
        samples = new List<string>();
        playerOccupied = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
