using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text countText;

    public float seconds, minutes;

    // Start is called before the first frame update
    void Start()
    {
        countText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        minutes = (int)(Time.time/60f);
        seconds = (int)(Time.time % 60f);
        countText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
