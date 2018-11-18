using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityApp;
using UnityEngine;
using UnityEngine.UI;
using System;
public class RecallImagesNamesBehaviourScript : MonoBehaviour
{


    public Text txtCounter;
    Stopwatch stopwatch = new Stopwatch();
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    DataService ds = new DataService(Utilities.DatabaseName);
    // Use this for initialization
    void Start()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.RecallNamesOfImagesMMSE);
        // get recent Session Images list
        //populate dropdowns
    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));

    }

    public void OnSubmit()
    {

    }

}
