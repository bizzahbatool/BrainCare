using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Diagnostics;
using TimeSpan = System.TimeSpan;
namespace UnityApp
{
    public class DrawCubeBehaviourScript : MonoBehaviour
    {

        public Text txtCounter;
        private Stopwatch stopwatch;
        TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
        DataService ds = new DataService(Utilities.DatabaseName);
        public Sprite SpriteImage;
        public Sprite SpriteImageVertical;
        public Image image1;
        public Image image2;
        public Image image3;
        public Image image4;
        public Image image5;
        public Image image6;
        public Image image7;
        public Image image8;
        public Image image9;
        public Image image10;
        public Image image11;
        public Image image12;
        public Image image13;
        public Image image14;
        int ClickedButton = 0;
        // Use this for initialization
        void Start()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.DrawCubeMoca);

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
            if (ClickedButton == 0)
            {
                image1.sprite = SpriteImage;
                ClickedButton = 1;
            }
        }
        public void OnBtn2Click()
        {
            if (ClickedButton == 1)
            {
                image2.sprite = SpriteImage;
                ClickedButton = 2;
            }
        }
        public void OnBtn3Click()
        {
            if (ClickedButton == 2)
            {
                image3.sprite = SpriteImage;
                ClickedButton = 3;
            }
        }
        public void OnBtn4Click()
        {
            if (ClickedButton == 3)
            {
                image4.sprite = SpriteImageVertical;
                ClickedButton = 4;
            }
        }
        public void OnBtn5Click()
        {
            if (ClickedButton == 4)
            {
                image5.sprite = SpriteImageVertical;
                ClickedButton = 5;
            }
        }
        public void OnBtn6Click()
        {
            if (ClickedButton == 5)
            {
                image6.sprite = SpriteImageVertical;
                ClickedButton = 6;
            }
        }
        public void OnBtn7Click()
        {
            if (ClickedButton == 6)
            {
                image14.sprite = SpriteImage;
                ClickedButton = 7;
            }
        }
        public void OnBtn8Click()
        {
            if (ClickedButton == 7)
            {
                image13.sprite = SpriteImage;
                ClickedButton = 8;
            }
        }
        public void OnBtn9Click()
        {
            if (ClickedButton == 8)
            {
                image12.sprite = SpriteImage;
                ClickedButton = 9;
            }
        }
        public void OnBtn10Click()
        {
            if (ClickedButton == 9)
            {
                image11.sprite = SpriteImageVertical;
                ClickedButton = 10;
            }
        }
        public void OnBtn11Click()
        {
            if (ClickedButton == 10)
            {
                image10.sprite = SpriteImageVertical;
                ClickedButton = 11;
            }
        }
        public void OnBtn12Click()
        {
            if (ClickedButton == 11)
            {
                image9.sprite = SpriteImageVertical;
                ClickedButton = 12;
            }
        }
        public void OnBtn13Click()
        {
            if (ClickedButton == 12)
            {
                image8.sprite = SpriteImageVertical;
                ClickedButton = 13;
            }
        }
        public void OnBtn14Click()
        {
            if (ClickedButton == 13)
            {
                image7.sprite = SpriteImageVertical;
                ClickedButton = 14;
            }
        }
        
        public void OnSubmitClick()
        {
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.DrawCircleMoca);
        }
        public void OnHomeClick()
        {
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
        }
    }
}