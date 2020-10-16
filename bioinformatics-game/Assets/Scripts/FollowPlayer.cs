using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public float speed = 3.0f;
    public float y_offset;
    public float z_offset;
    public float x_offset;
    // Update is called once per frame
    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y + y_offset, interpolation);
        position.z = Mathf.Lerp(this.transform.position.z, player.transform.position.z + z_offset, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x + x_offset, interpolation);

        this.transform.position = position;
    }

}
