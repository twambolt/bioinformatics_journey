using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AAPhyloScripts : MonoBehaviour
{
    public GameObject AaHomeDisplay;
    public GameObject CompHomeDisplay;
    public GameObject CalcDisplay;
    public ComputerController compController;

    public GameObject AH_Dist_Phylo;
    public GameObject AH_Max_Phylo;
    public GameObject AH_Pers_Phylo;
    public GameObject KC_Dist_Phylo;
    public GameObject KC_Max_Phylo;
    public GameObject KC_Pers_Phylo;


    bool[] viewed = new bool[6];

    public int dataSelect;
    public int algSelect;



    // Start is called before the first frame update
    void Start()
    {
        algSelect = 0;
        dataSelect = 0;

        viewed[0] = false;
        viewed[1] = false;
        viewed[2] = false;
        viewed[3] = false;
        viewed[4] = false;
        viewed[5] = false;
    }

    public void BackButtonAaHome() //back to computer home
    {
        AaHomeDisplay.SetActive(false);
        CompHomeDisplay.SetActive(true);
    }

    public void CalcPhyloButton()
    {
        AaHomeDisplay.SetActive(false);
        CalcDisplay.SetActive(true);
        ShowCorrectPhylo();
    }

    public void BackButtonCalc() //back to computer home
    {
        CalcDisplay.SetActive(false);
        AaHomeDisplay.SetActive(true);

        AH_Dist_Phylo.SetActive(false);
        AH_Max_Phylo.SetActive(false);
        AH_Pers_Phylo.SetActive(false);
        KC_Dist_Phylo.SetActive(false);
        KC_Max_Phylo.SetActive(false);
        KC_Pers_Phylo.SetActive(false);
    }

    public void CompleteModule()
    {
        CalcDisplay.SetActive(false);
        CompHomeDisplay.SetActive(true);
        compController.completed[1] = true;
    }



    public void ShowCorrectPhylo()
    {
        if (dataSelect == 0 && algSelect == 0)
        {
            AH_Dist_Phylo.SetActive(true);
            viewed[0] = true;
            return;
        }

        if (dataSelect == 0 && algSelect == 1)
        {
            AH_Max_Phylo.SetActive(true);
            viewed[1] = true;
            return;
        }

        if (dataSelect == 0 && algSelect == 2)
        {
            AH_Pers_Phylo.SetActive(true);
            viewed[2] = true;
            return;
        }

        if (dataSelect == 1 && algSelect == 0)
        {
            KC_Dist_Phylo.SetActive(true);
            viewed[3] = true;
            return;
        }

        if (dataSelect == 1 && algSelect == 1)
        {
            KC_Max_Phylo.SetActive(true);
            viewed[4] = true;
            return;
        }

        if (dataSelect == 1 && algSelect == 2)
        {
            KC_Pers_Phylo.SetActive(true);
            viewed[5] = true;
            return;
        }

        else
        {
            Debug.Log("Error");
            Debug.Log(string.Format("dataSelect: {0} algSelect: {1}", dataSelect, algSelect));
            print(string.Format("dataSelect: {0} algSelect: {1}", dataSelect, algSelect));
            return;
        }
    }


    public void HandleInputDataset(int val)
    {
        dataSelect = val;
    }


    public void HandleInputAlg(int val)
    {
        algSelect = val;
    }

}
