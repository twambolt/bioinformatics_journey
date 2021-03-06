﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DnaPhyloScripts : MonoBehaviour
{
    public GameObject DnaHomeDisplay;
    public GameObject CompHomeDisplay;
    public GameObject CalcDisplay;
    public ComputerController compController;

    public GameObject DistPhylo;
    public GameObject MaxPhylo;
    public GameObject ParsePhylo;

    public GameObject completeModuleButton;

    public bool[] viewed = new bool[3];

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

    public void BackButtonCalc() //back to DNA home
    {
        CalcDisplay.SetActive(false);
        DnaHomeDisplay.SetActive(true);

        DistPhylo.SetActive(false);
        MaxPhylo.SetActive(false);
        ParsePhylo.SetActive(false);
    }

    public void CompleteModule()
    {
        DistPhylo.SetActive(false);
        MaxPhylo.SetActive(false);
        ParsePhylo.SetActive(false);
        CalcDisplay.SetActive(false);
        CompHomeDisplay.SetActive(true);
        compController.completed[2] = true;
        compController.RecalcCompleted();
    }

    public void ModuleProgress()
    {
        int count = 0;
        for (int i = 0; i < viewed.Length; i++)
        {
            if (viewed[i])
                count++;
        }
        if (count == 3)
        {
            completeModuleButton.SetActive(true);
        }

    }

    public void ShowCorrectPhylo()
    {
        if (dataSelect == 0 && algSelect == 0)
        {
            DistPhylo.SetActive(true);
            viewed[0] = true;
        }
        else if (dataSelect == 0 && algSelect == 1)
        {
            MaxPhylo.SetActive(true);
            viewed[1] = true;
        }
        else if (dataSelect == 0 && algSelect == 2)
        {
            ParsePhylo.SetActive(true);
            viewed[2] = true;
        }

        else
        {
            Debug.Log("Error");
            Debug.Log(string.Format("dataSelect: {0} algSelect: {1}", dataSelect, algSelect));
            print(string.Format("dataSelect: {0} algSelect: {1}", dataSelect, algSelect));
        }
        ModuleProgress();
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
