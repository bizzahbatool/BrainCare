using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Controllers.Services;
using System.Diagnostics;
using UnityEngine.UI;
using System.Linq;
using System.Text;
using Random = System.Random;
using Assets.Controllers.Models;
using UnityApp;
using UnityEngine.SceneManagement;
using System;

public class NameObjectBehaviourScript : MonoBehaviour
{

    #region Declarations
    public Text btnTextWord1;
    public Text btnTextWord2;
    public Text btnTextWord3;
    public Text btnTextWord4;

    public Button btnWord1;
    public Button btnWord2;
    public Button btnWord3;
    public Button btnWord4;

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
    public Image ImgToSelect;
    private Stopwatch stopwatch = new Stopwatch();
    ColorBlock colorBloack = new ColorBlock();
    private List<ImageDescription> ImageDescriptionList = ImageDescriptionServices.GetImageList().Take(4).ToList();
    private string SelectedString = string.Empty;
    private ImageDescription ImageDescription = new ImageDescription();
    public Text txtCounter;
    DataService ds = new DataService(Utilities.DatabaseName);
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    private static Random random = new Random();
    #endregion
    // Use this for initialization
    void Start()
    {
        try
        {
            stopwatch.Start();
            //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.NameObjectMMSE);
            ImageDescription = ImageDescriptionList[random.Next(0, 3)];
            var shuffleString = RandomString().ToArray();
            ImgToSelect.sprite = GetSpriteToDisplay(ImageDescription.ImageName);

            btnTextWord1.text = ImageDescriptionList[int.Parse(shuffleString[0].ToString())].ImageName;
            btnTextWord2.text = ImageDescriptionList[int.Parse(shuffleString[1].ToString())].ImageName;
            btnTextWord3.text = ImageDescriptionList[int.Parse(shuffleString[2].ToString())].ImageName;
            btnTextWord4.text = ImageDescriptionList[int.Parse(shuffleString[3].ToString())].ImageName;

        }
        catch (System.Exception)
        {
        }
    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }
    public void OnButton1CLick()
    {
        btnWord1.colors = new ColorBlock();
        SelectedString = btnTextWord1.text;
    }
    public void OnButton2CLick()
    {
        btnWord2.colors = new ColorBlock();
        SelectedString = btnTextWord2.text;
    }
    public void OnButton3CLick()
    {
        btnWord3.colors = new ColorBlock();
        SelectedString = btnTextWord3.text;
    }
    public void OnButton4CLick()
    {
        btnWord4.colors = new ColorBlock();
        SelectedString = btnTextWord4.text;
    }
    public void OnSubmitClick()
    {
        NameObject model = new NameObject
        {
            NameOfObject = ImageDescription.ImageName,
            SelectedNameOfObject = SelectedString,
            Correct = ImageDescription.ImageName.Equals(SelectedString),
            ScreenNumber = 1,
            TimeToComplete = stopwatch.Elapsed
        };
        ds.CreateNameObjectMMSE(model);
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.NameObject2MMSE);
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
        return null;
    }

    private string RandomString()
    {
        const string chars = "0123";
        return new string(chars.OrderBy(r => random.Next()).ToArray());
    }

}
