using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTorre : MonoBehaviour
{
    public GameObject torre;


    void OnMouseDown()
    {
        Debug.Log("Click");

        GameObject temp;
        Vector3 pos = this.transform.position;
        // pos.y = pos.y + .4f;
        temp = Instantiate(torre);
        temp.transform.position = pos;
        temp.layer = 1;
        Destroy(this.gameObject);


    }
}
