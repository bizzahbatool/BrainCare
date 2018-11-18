using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ConnectDotsBehaviourScript : MonoBehaviour {


    public Image Img1A;
    public Image ImgA2;
    public Image Img2B;
    public Image ImgB3;
    public Image Img3C;
    public Image ImgC4;
    public Image Img4D;
    public Image ImgD5;
    public Image Img5E;
    public Image Img1;
    public Image ImgA;
    public Image Img2;
    public Image ImgB;
    public Image Img3;
    public Image ImgC;
    public Image Img4;
    public Image ImgD;
    public Image Img5;
    public Image ImgE;

    public Sprite Img1Invert;
    public Sprite ImgAInvert;
    public Sprite Img2Invert;
    public Sprite ImgBInvert;
    public Sprite Img3Invert;
    public Sprite ImgCInvert;
    public Sprite Img4Invert;
    public Sprite ImgDInvert;
    public Sprite Img5Invert;
    public Sprite ImgEInvert;

    TimeSpan TimeSpanDispay;
    public Sprite spriteLine;
    private string RecentClick = string.Empty;
    public int CorrectClicks { get; set; }
    public int WrnogClicks { get; set; }
    public Text txtCounter;
    public Stopwatch stopwatch ;
    DataService ds = new DataService(Utilities.DatabaseName);
    // Use this for initialization
    void Start ()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.ConnectDotsMoca);
        TimeSpanDispay = new TimeSpan(0, 0, 30);
        stopwatch = new Stopwatch();
        stopwatch.Start();
	}
	
	// Update is called once per frame
	void Update () {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));

    }
    public void OnSubmitButton()
    {
        var ds = new DataService(Utilities.DatabaseName);
        ConnectDots model = new ConnectDots
        {
            CorrectClicks = CorrectClicks,
            WrongClikcs = WrnogClicks,
            TimeToComplete = stopwatch.Elapsed
        };
        ds.CreateConnectDotsMoca(model);
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.DrawCubeMoca);
    }
    public void onClickbtn1()
    {
        Img1.sprite = Img1Invert;
        if (RecentClick==string.Empty)
        {
            RecentClick = "1";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    public void onClickbtn2()
    {
        Img2.sprite = Img2Invert;
        if (RecentClick == "A")
        {
            ImgA2.sprite = spriteLine;
            RecentClick = "2";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtn3()
    {
        Img3.sprite = Img3Invert;
        if (RecentClick == "B")
        {
            ImgB3.sprite = spriteLine;
            RecentClick = "3";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtn4()
    {
        Img4.sprite = Img4Invert;
        if (RecentClick == "C")
        {
            ImgC4.sprite = spriteLine;
            RecentClick = "4";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtn5()
    {
        Img5.sprite = Img5Invert;
        if (RecentClick == "D")
        {
            ImgD5.sprite = spriteLine;
            RecentClick = "5";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtnA()
    {
        ImgA.sprite = ImgAInvert;
        if (RecentClick == "1")
        {
            Img1A.sprite = spriteLine;
            RecentClick = "A";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtnB()
    {
        ImgB.sprite = ImgBInvert;
        if (RecentClick == "2")
        {
            Img2B.sprite = spriteLine;
            RecentClick = "B";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtnC()
    {
        ImgC.sprite = ImgCInvert;
        if (RecentClick == "3")
        {
            Img3C.sprite = spriteLine;
            RecentClick = "C";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtnD()
    {
        ImgD.sprite = ImgDInvert;
        if (RecentClick == "4")
        {
            Img4D.sprite = spriteLine;
            RecentClick = "D";
            CorrectClicks++;
        }
        else
            WrnogClicks++;
    }

    public void onClickbtnE()
    {
        ImgE.sprite = ImgEInvert;
        if (RecentClick == "5")
        {
            Img5E.sprite = spriteLine;
            RecentClick = "E";
            CorrectClicks++;
        }
        else
        WrnogClicks++;
    }


}
