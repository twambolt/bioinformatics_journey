using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButtonScripts : MonoBehaviour
{

    public GameObject computerHome;

    public GameObject MorphPhyloDisplayHome;
    public GameObject DNAPhyloHome;
    public GameObject AAPhyloHome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MorphPhyloButton()
    {
        computerHome.SetActive(false);
        MorphPhyloDisplayHome.SetActive(true);
    }

    public void DNAPhyloButton()
    {
        computerHome.SetActive(false);
        DNAPhyloHome.SetActive(true);
    }

    public void AAPhyloButton()
    {
        computerHome.SetActive(false);
        AAPhyloHome.SetActive(true);
    }

}
