using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberOnClockBehaviourScript : MonoBehaviour
{

    string InputField1 = string.Empty;
    string InputField2 = string.Empty;
    string InputField3 = string.Empty;
    string InputField4 = string.Empty;
    string InputField5 = string.Empty;
    string InputField6 = string.Empty;
    string InputField7 = string.Empty;
    string InputField8 = string.Empty;
    string InputField9 = string.Empty;
    string InputField10 = string.Empty;
    string InputField11 = string.Empty;
    string InputField12 = string.Empty;
    int Incorrect = 0;
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    public Text txtCounter;
    Stopwatch stopwatch = new Stopwatch();
    DataService ds = new DataService(Utilities.DatabaseName);
    // Use this for initialization
    void Start()
    {

        ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.NumberOnClockMoca);
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {

        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }


    public void OnClickSubmitButton()
    {
        var ds = new DataService(Utilities.DatabaseName);
        NumberOnClock model = new NumberOnClock
        {
            Correct = Validate(),
            IncorrectItems = Incorrect,
            TimeToComplete = stopwatch.Elapsed
        };
        ds.CreateNumberOnClock(model);
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.ClockArmsMoca);
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    private bool Validate()
    {
        bool validate = true;
        if (!InputField1.Equals("1"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField2.Equals("2"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField3.Equals("3"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField4.Equals("4"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField5.Equals("5"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField6.Equals("6"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField7.Equals("7"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField8.Equals("8"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField9.Equals("9"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField10.Equals("10"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField11.Equals("11"))
        {
            Incorrect++;
            validate = false;
        }
        if (!InputField12.Equals("12"))
        {
            Incorrect++;
            validate = false;
        }
        return validate;
    }
    #region Setting Input
    public void SetInputField1(string txt)
    {
        InputField1 = txt;
    }

    public void SetInputField2(string txt)
    {
        InputField2 = txt;
    }

    public void SetInputField3(string txt)
    {
        InputField3 = txt;
    }

    public void SetInputField4(string txt)
    {
        InputField4 = txt;
    }

    public void SetInputField5(string txt)
    {
        InputField5 = txt;
    }

    public void SetInputField6(string txt)
    {
        InputField6 = txt;
    }

    public void SetInputField7(string txt)
    {
        InputField7 = txt;
    }

    public void SetInputField8(string txt)
    {
        InputField8 = txt;
    }

    public void SetInputField9(string txt)
    {
        InputField9 = txt;
    }
    public void SetInputField10(string txt)
    {
        InputField10 = txt;
    }
    public void SetInputField11(string txt)
    {
        InputField11 = txt;
    }
    public void SetInputField12(string txt)
    {
        InputField12 = txt;
    }

    #endregion
}
