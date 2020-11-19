using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPosition : MonoBehaviour
{

    public GameObject player;

    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        OnCollisionEnter(collision);
    }

    void OnCollisionEnter(Collision collision)
    {
        player.transform.position = startPosition;
    }
}
