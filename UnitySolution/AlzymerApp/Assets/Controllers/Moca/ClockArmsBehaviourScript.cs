using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.SceneManagement;
using UnityApp;
using System;

public class ClockArmsBehaviourScript : MonoBehaviour
{
    float rotSpeed = 25;
    public Image MinuteImage;
    public Image HourImage;
    public Text textWarning;
    private float LowerLimitMinute = -0.28f;
    private float HigherLimitMinute = -0.38f;

    private float LowerLimitHour = 0.80f;
    private float HigherLimitHour = 0.90f;
    Stopwatch stopwatch = new Stopwatch();
    TimeSpan TimeSpanDispay = new TimeSpan(0,0,30);

    TimeSpan timespan = new TimeSpan();
    TimeSpan Thresholdtimespan = new TimeSpan(0, 0, 5);
    DataService ds = new DataService(Utilities.DatabaseName);
    public Text txtCounter;
    // Use this for initialization
    void Start()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.ClockArmsMoca);
        stopwatch.Start();

    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));

        if (timespan.Add(Thresholdtimespan).Seconds == stopwatch.Elapsed.Seconds &&
            textWarning != null)
        {
            textWarning.text = string.Empty;
        }
    }

    public void OnbackClick()
    {
        float OffsetZAxisHour = +2.05f;
        float OffsetZAxisMiunte = +30f;
        HourImage.transform.Rotate(Vector3.forward, OffsetZAxisHour);
        MinuteImage.transform.Rotate(Vector3.forward, OffsetZAxisMiunte);
    }
    public void OnForwardCLick()
    {
        float OffsetZAxisHour = -2.05f;
        float OffsetZAxisMiunte = -30f;
        HourImage.transform.Rotate(Vector3.forward, OffsetZAxisHour);
        MinuteImage.transform.Rotate(Vector3.forward, OffsetZAxisMiunte);
    }
    public void OnSubmitClick()
    {
        if (true)//to be fixed
        {
            var ds = new DataService(UnityApp.Utilities.DatabaseName);
            ClockArams model = new ClockArams
            {
                TimeToComplete = stopwatch.Elapsed
            };
            ds.CreateClockArams(model);
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.RecognizeAnimalMoca);
        }
        else
        {
            timespan = stopwatch.Elapsed;
            textWarning.text = string.Format("The clock arms are not at correct positions.");
        }

    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    private bool Validate()
    {
        if (!(MinuteImage.rectTransform.rotation.z <= LowerLimitMinute &&
            MinuteImage.rectTransform.rotation.z >= HigherLimitMinute))
        {
            return false;
        }
        if (!(HourImage.rectTransform.rotation.z >= LowerLimitHour &&
            HourImage.rectTransform.rotation.z <= HigherLimitHour))
        {
            return false;
        }
        return true;
    }
}
