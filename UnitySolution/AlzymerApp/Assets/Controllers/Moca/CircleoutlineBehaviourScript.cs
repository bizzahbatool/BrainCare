using System;
using System.Diagnostics;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CircleoutlineBehaviourScript : MonoBehaviour
{

    public Stopwatch stopwatch;
    public Text txtCounter;
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    int SelectedImage = 0;
    public Sprite ImageSprite;
    public Image Image1;
    public Image Image2;
    public Image Image3;
    public Image Image4;
    public Image Image5;
    public Image Image6;
    public Image Image7;
    public Image Image8;
    public Image Image9;
    public Image Image10;
    public Image Image11;
    public Image Image12;
    public Image Image13;
    public Image Image14;
    public Image Image15;
    public Image Image16;
    public Image Image17;
    public Image Image18;
    public Image Image19;
    public Image Image20;
    public Image Image21;
    public Image Image22;
    public Image Image23;
    public Image Image24;
    DataService ds = new DataService(Utilities.DatabaseName);
    // Use this for initialization
    void Start()
    {
        stopwatch = new Stopwatch();

        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.DrawCircleMoca);
    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));

    }
    public void OnBtn1Click()
    {
        if (SelectedImage == 0)
        {
            Image1.sprite = ImageSprite;
            SelectedImage = 1;
        }
    }
    public void OnBtn2Click()
    {
        if (SelectedImage == 1)
        {
            Image2.sprite = ImageSprite;
            SelectedImage = 2;
        }
    }
    public void OnBtn3Click()
    {
        if (SelectedImage == 2)
        {
            Image3.sprite = ImageSprite;
            SelectedImage = 3;
        }
    }
    public void OnBtn4Click()
    {
        if (SelectedImage == 3)
        {
            Image4.sprite = ImageSprite;
            SelectedImage = 4;
        }
    }
    public void OnBtn5Click()
    {
        if (SelectedImage == 4)
        {
            Image5.sprite = ImageSprite;
            SelectedImage = 5;
        }
    }
    public void OnBtn6Click()
    {
        if (SelectedImage == 5)
        {
            Image6.sprite = ImageSprite;
            SelectedImage = 6;
        }
    }
    public void OnBtn7Click()
    {
        if (SelectedImage == 6)
        {
            Image7.sprite = ImageSprite;
            SelectedImage = 7;
        }
    }
    public void OnBtn8Click()
    {
        if (SelectedImage == 7)
        {
            Image8.sprite = ImageSprite;
            SelectedImage = 8;
        }
    }
    public void OnBtn9Click()
    {
        if (SelectedImage == 8)
        {
            Image9.sprite = ImageSprite;
            SelectedImage = 9;
        }
    }
    public void OnBtn10Click()
    {
        if (SelectedImage == 9)
        {
            Image10.sprite = ImageSprite;
            SelectedImage = 10;
        }
    }
    public void OnBtn11Click()
    {
        if (SelectedImage == 10)
        {
            Image11.sprite = ImageSprite;
            SelectedImage = 11;
        }
    }
    public void OnBtn12Click()
    {
        if (SelectedImage == 11)
        {
            Image12.sprite = ImageSprite;
            SelectedImage = 12;
        }
    }
    public void OnBtn13Click()
    {
        if (SelectedImage == 12)
        {
            Image13.sprite = ImageSprite;
            SelectedImage = 13;
        }
    }
    public void OnBtn14Click()
    {
        if (SelectedImage == 13)
        {
            Image14.sprite = ImageSprite;
            SelectedImage = 14;
        }
    }
    public void OnBtn15Click()
    {
        if (SelectedImage ==14)
        {
            Image15.sprite = ImageSprite;
            SelectedImage = 15;
        }
    }
    public void OnBtn16Click()
    {
        if (SelectedImage == 15)
        {
            Image16.sprite = ImageSprite;
            SelectedImage = 16;
        }
    }
    public void OnBtn17Click()
    {
        if (SelectedImage == 16)
        {
            Image17.sprite = ImageSprite;
            SelectedImage = 17;
        }
    }
    public void OnBtn18Click()
    {
        if (SelectedImage == 17)
        {
            Image19.sprite = ImageSprite;
            SelectedImage = 18;
        }
    }
    public void OnBtn19Click()
    {
        if (SelectedImage == 18)
        {
            Image19.sprite = ImageSprite;
            SelectedImage = 19;
        }
    }
    public void OnBtn20Click()
    {
        if (SelectedImage == 19)
        {
            Image20.sprite = ImageSprite;
            SelectedImage = 20;
        }
    }
    public void OnBtn21Click()
    {
        if (SelectedImage == 20)
        {
            Image21.sprite = ImageSprite;
            SelectedImage = 21;
        }
    }
    public void OnBtn22Click()
    {
        if (SelectedImage == 21)
        {
            Image22.sprite = ImageSprite;
            SelectedImage = 22;
        }
    }
    public void OnBtn23Click()
    {
        if (SelectedImage == 22)
        {
            Image23.sprite = ImageSprite;
            SelectedImage = 23;
        }
    }
    public void OnBtn24Click()
    {
        if (SelectedImage == 23)
        {
            Image24.sprite = ImageSprite;
            SelectedImage = 24;
        }
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    public void OnSubmitClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.NumberOnClockMoca);
    }
}
