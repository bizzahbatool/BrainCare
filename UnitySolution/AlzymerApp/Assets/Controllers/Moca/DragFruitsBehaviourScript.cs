using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DragFruitsBehaviourScript : MonoBehaviour {
    public Text txtCounter;
    float OffsetXAxis;
    float OffsetYAxis;
    Stopwatch stopwatch = new Stopwatch();
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    DataService ds = new DataService(Utilities.DatabaseName);
    // Use this for initialization
    void Start ()
    {
        ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.DragFruitsMoca);
        stopwatch.Start();

    }
	
	// Update is called once per frame
	void Update () {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }

    public void BeginBananaDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }

    public void OnBananaDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }


    public void BeginCabbageDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }

    public void OnCabbageDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }

    public void BeginAppleDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }

    public void OnAppleDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }

    public void BeginCaraotDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }
    public void OnSubmitClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    public void OnCaraotDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }
}
