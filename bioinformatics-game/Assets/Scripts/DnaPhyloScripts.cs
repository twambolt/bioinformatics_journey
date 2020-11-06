using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DnaPhyloScripts : MonoBehaviour
{
    public GameObject DnaHomeDisplay;
    public GameObject CompHomeDisplay;
    public GameObject CalcDisplay;
    public ComputerController compController;
    public TextMeshProUGUI test;

    bool[] viewed = new bool[6];

    public int dataSelect;
    public int algSelect;
    


    // Start is called before the first frame update
    void Start()
    {
        algSelect = -1;
        dataSelect = -1;

        viewed[0] = false;
        viewed[1] = false;
        viewed[2] = false;
        viewed[3] = false;
        viewed[4] = false;
        viewed[5] = false;
    }

    public void BackButtonDNAHome() //back to computer home
    {
        DnaHomeDisplay.SetActive(false);
        CompHomeDisplay.SetActive(true);
    }

    public void CalcPhyloButton()
    {
        DnaHomeDisplay.SetActive(false);
        CalcDisplay.SetActive(true);
        ShowCorrectPhylo();
    }

    public void BackButtonCalc() //back to computer home
    {
        CalcDisplay.SetActive(false);
        DnaHomeDisplay.SetActive(true);
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
            test.text = "Phylo 0";
            viewed[0] = true;
            return;
        }

        if (dataSelect == 0 && algSelect == 1)
        {
            test.text = "Phylo 1";
            viewed[1] = true;
            return;
        }

        if (dataSelect == 0 && algSelect == 2)
        {
            test.text = "Phylo 2";
            viewed[2] = true;
            return;
        }

        if (dataSelect == 1 && algSelect == 0)
        {
            test.text = "Phylo 3";
            viewed[3] = true;
            return;
        }

        if (dataSelect == 1 && algSelect == 1)
        {
            test.text = "Phylo 4";
            viewed[4] = true;
            return;
        }

        if (dataSelect == 1 && algSelect == 2)
        {
            test.text = "Phylo 5";
            viewed[5] = true;
            return;
        }

        else
        {
            test.text = "error";
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


    //public void PopulateDropdowns()
    //{
    //    algorithmDD.AddOptions(algorithms);
    //    dataDD.AddOptions(datasets);
    //}

}
