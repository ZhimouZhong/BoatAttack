using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class eventSystemLog : MonoBehaviour
{
    public Text showText;
    public EventSystem eventSys;
    // Update is called once per frame
    void Update()
    {
        showText.text = eventSys.ToString();
        UnityEngine.Debug.Log(eventSys.ToString());
    }

}
