using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphPhyloScripts : MonoBehaviour
{

    public GameObject MorphHomeDisplay;
    public GameObject CompHomeDisplay;
    public GameObject BuildMorphDisplay;
    public GameObject HypMorphDisplay;

    public ComputerController compController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButtonHome()
    {
        MorphHomeDisplay.SetActive(false);
        CompHomeDisplay.SetActive(true);
    }

    public void BuildMorphButton()
    {
        MorphHomeDisplay.SetActive(false);
        BuildMorphDisplay.SetActive(true);
    }

    public void BackButtonBuild()
    {
        BuildMorphDisplay.SetActive(false);
        MorphHomeDisplay.SetActive(true);
    }

    public void HypMorphButton()
    {
        BuildMorphDisplay.SetActive(false);
        HypMorphDisplay.SetActive(true);
    }

    public void BackButtonHyp()
    {
        HypMorphDisplay.SetActive(false);
        BuildMorphDisplay.SetActive(true);
    }

    public void CompleteMorphButton()
    {
        compController.completed[0] = true;
        HypMorphDisplay.SetActive(false);
        CompHomeDisplay.SetActive(true);
    }


}
