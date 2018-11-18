using Assets.Controllers.Models;
using Assets.Controllers.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Linq;
using UnityApp;
using UnityEngine.SceneManagement;
using System;

public class RecallImagesBehaviourScript : MonoBehaviour
{

    public Image Image1;
    public Text txtCounter;
    public Text TextImage1;
    public Sprite Book;
    public Sprite Pen;
    public Sprite Gift;
    public Sprite InkPot;
    public Sprite Chair;
    public Sprite Clock;
    public Sprite Watch;
    public Sprite TeleVision;
    public Sprite Desk;
    public Sprite Bottle;
    private Stopwatch stopwatch = new Stopwatch();
    DataService ds = new DataService(Utilities.DatabaseName);
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    public List<ImageDescription> ImageDescriptionList { get; set; }
    // Use this for initialization
    void Start()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.RecallImageMMSE);
        ImageDescriptionList = ImageDescriptionServices.GetImageList().Take(2).ToList();
        TextImage1.text = ImageDescriptionList[0].ImageName;

        Image1.sprite = GetSpriteToDisplay(ImageDescriptionList[0].ImageName);
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }

    public void OnSubmitButtonClick()
    {
        try
        {
            RecallImages model = new RecallImages
            {
                Image1 = ImageDescriptionList[0].ImageName,
                Image2 = string.Empty,
                Image3 = string.Empty,
                TimeToComplete = stopwatch.Elapsed
            };
            ds.CreateRecallImagesMMSE(model);
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.SerialSevenMMSE);
        }
        catch (System.Exception)
        {

        }

    }

    public void OnSubmit2ButtonClick()
    {
        try
        {
            RecallImages model = new RecallImages
            {
                Image1 = ImageDescriptionList[0].ImageName,
                Image2 = string.Empty,
                Image3 = string.Empty,
                TimeToComplete = stopwatch.Elapsed
            };
            ds.CreateRecallImagesMMSE(model);
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.RecallImages2MMSE);
        }
        catch (System.Exception)
        {

        }

    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }

    private Sprite GetSpriteToDisplay(string name)
    {
        switch (name)
        {
            case "Book":
                return Book;
            case "Pen":
                return Pen;
            case "Gift":
                return Gift;
            case "Ink Pot":
                return InkPot;
            case "Chair":
                return Chair;
            case "Clock":
                return Clock;
            case "Watch":
                return Watch;
            case "Tele Vision":
                return TeleVision;
            case "Desk":
                return Desk;
            case "Bottle":
                return Bottle;
        }
        return new Sprite();
    }
}
