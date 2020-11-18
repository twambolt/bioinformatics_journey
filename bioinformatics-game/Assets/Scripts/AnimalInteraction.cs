using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalInteraction : MonoBehaviour
{
    public GameObject targetJE;
    public GameObject interactTip;
    public string animalName;

    public GameManager gameManager;
    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        CollectSample();
    }

    public void CollectSample()
    {
        if (inRange && Input.GetKeyDown("f"))
        {
            targetJE.SetActive(true);
            UpdateAnimalList();
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        interactTip.SetActive(true);
        inRange = true;
    }

    public void OnTriggerExit(Collider other)
    {
        interactTip.SetActive(false);
        inRange = false;
    }


    public void UpdateAnimalList()
    {
        switch (animalName)
        {
            case "giraffe":
                gameManager.animalsCollected[0] = true;
                break;
            case "hippo":
                gameManager.animalsCollected[1] = true;
                break;
            case "horse":
                gameManager.animalsCollected[2] = true;
                break;
            case "peccary":
                gameManager.animalsCollected[3] = true;
                break;
            case "camel":
                gameManager.animalsCollected[4] = true;
                break;
            case "zebra":
                gameManager.animalsCollected[5] = true;
                break;
            case "shark":
                gameManager.animalsCollected[6] = true;
                break;
            case "deer":
                gameManager.animalsCollected[7] = true;
                break;
            case "whale":
                gameManager.animalsCollected[8] = true;
                break;
            case "elephant":
                gameManager.animalsCollected[9] = true;
                break;
            case "fish":
                gameManager.animalsCollected[10] = true;
                break;
            case "manatee":
                gameManager.animalsCollected[11] = true;
                break;
            default:
                Debug.Log("error unknown animal collected");
                break;
        }
        gameManager.RecalcFoundAnimals();
    }


}
