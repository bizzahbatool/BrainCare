using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using Assets.Controllers.Models;
using Assets.Controllers.Services;
using UnityApp;
using UnityEngine.SceneManagement;
using System.Linq;
using System;
using System.Text;

public class SerialSevenBehaviourScript : MonoBehaviour
{

    public Text txtCounter;
    public Text txtFigureLarge;
    public Text txtFigureSmall;
    public Text txtSum;
    int InputValue = 0;
    private Stopwatch stopwatch = new Stopwatch();
    public List<SerialSevenViewModel> model;
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    DataService ds = new DataService(Utilities.DatabaseName);
    int counterList = 0;
    string sum =string.Empty;
    private StringBuilder sb = new StringBuilder(); 
    // Use this for initialization
    void Start()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.SerialSevenMMSE);
        model = SerialSevenServices.GetList();
        txtFigureLarge.text = model[counterList].Maximum.ToString();
        txtFigureSmall.text = model[counterList].Minimum.ToString();


        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }

    public void OnClickCalculateButton()
    {
        sb = new StringBuilder();
        txtSum.text = "00";
        int maximumNumber = int.Parse(txtFigureLarge.text);
        int smallNumber = int.Parse(txtFigureSmall.text);
        int answer = InputValue;
        model[counterList].Correct = answer + smallNumber == maximumNumber;
        counterList++;
        if (model[counterList].Maximum == 65 )
        {
            SerialSeven Datamodel = new SerialSeven
            {
                CorrectList = model.Count(i => i.Correct),
                InCorrectList = model.Count(i => !i.Correct),
                TimeToComplete = stopwatch.Elapsed
            };
            ds.CreateSerialSevenMMSE(Datamodel);
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.CompleteSentenceMMSE);
        }
        txtFigureLarge.text = model[counterList].Maximum.ToString();
        txtFigureSmall.text = model[counterList].Minimum.ToString();

    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    public void OnBtn1Click()
    {
        sb.Append("1");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn2Click()
    {
        sb.Append("2");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn3Click()
    {
        sb.Append("3");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn4Click()
    {
        sb.Append("4");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn5Click()
    {
        sb.Append("5");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn6Click()
    {
        sb.Append("6");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn7Click()
    {
        sb.Append("7");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn8Click()
    {
        sb.Append("8");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn9Click()
    {
        sb.Append("9");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtn0Click()
    {
        sb.Append("10");
        InputValue = int.Parse(sb.ToString());
        txtSum.text = sb.ToString();
    }
    public void OnBtnClearClick()
    {
        sb = new StringBuilder();
        txtSum.text = "00";
    }
}
