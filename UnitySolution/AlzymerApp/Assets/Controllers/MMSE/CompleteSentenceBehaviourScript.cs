using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Controllers.Services;
using System.Diagnostics;
using UnityEngine.UI;
using System.Linq;
using System.Text;
using Random = System.Random;
using StringBuilder = System.Text.StringBuilder;
using UnityApp;
using UnityEngine.SceneManagement;
using System;
using ColorBlock = UnityEngine.UI.ColorBlock;
public class CompleteSentenceBehaviourScript : MonoBehaviour
{

    #region Declarations
    public List<string> Sentences
    {
        get
        {
            return CompleteSentenceServices.Sentences;
        }
    }
    public Text txtWord1;

    public Text btnWord1;
    public Text btnWord2;
    public Text btnWord3;
    public Text btnWord4;
    public Text btnWord5;
    public Button Btn1;
    public Button Btn2;
    public Button Btn3;
    public Button Btn4;
    public Button Btn5;
    string BasicString = @"----------------------------------";
    private Stopwatch stopwatch = new Stopwatch();
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    public Text txtCounter;
    private static Random random = new Random();
    private StringBuilder stringBuilder = new StringBuilder();
    string OriginalSentence = string.Empty;
    DataService ds = new DataService(Utilities.DatabaseName, true);
    ColorBlock cb = new ColorBlock();
    #endregion

    // Use this for initialization
    void Start()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.CompleteSentenceMMSE);
        stopwatch.Start();
        cb = Btn1.colors;
        var characterArray = ShuffleString(Sentences[random.Next(0, 6)].Split(' '));
        btnWord1.text = characterArray[0];
        btnWord2.text = characterArray[1];
        btnWord3.text = characterArray[2];
        btnWord4.text = characterArray[3];
        btnWord5.text = characterArray[4];
        OriginalSentence = string.Format("{0} {1} {2} {3} {4}",
            btnWord1.text,
            btnWord2.text,
            btnWord3.text,
            btnWord4.text,
            btnWord5.text
            );
    }

    // Update is called once per frame
    void Update()
    {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }
    public void OnButton1Click()
    {
        Btn1.colors = new ColorBlock();
        stringBuilder.Append(string.Format(@"{0} ", btnWord1.text));
        txtWord1.text = stringBuilder.ToString();
    }
    public void OnButton2Click()
    {
        Btn2.colors = new ColorBlock();
        stringBuilder.Append(string.Format(@"{0} ", btnWord2.text));
        txtWord1.text = stringBuilder.ToString();
    }
    public void OnButton3Click()
    {
        Btn3.colors = new ColorBlock();
        stringBuilder.Append(string.Format(@"{0} ", btnWord3.text));
        txtWord1.text = stringBuilder.ToString();
    }
    public void OnButton4Click()
    {
        Btn4.colors = new ColorBlock();
        stringBuilder.Append(string.Format(@"{0} ", btnWord4.text));
        txtWord1.text = stringBuilder.ToString();
    }
    public void OnButton5Click()
    {
        Btn5.colors = new ColorBlock();
        stringBuilder.Append(string.Format(@"{0} ", btnWord5.text));
        txtWord1.text = stringBuilder.ToString();
    }
    public void OnButtonRefreshClick()
    {
        Btn1.colors = cb;
        Btn2.colors = cb;
        Btn3.colors = cb;
        Btn4.colors = cb;
        Btn5.colors = cb;
        stringBuilder = new StringBuilder();
        txtWord1.text = BasicString;
    }
    public void OnSubmitButtonCLick()
    {

        string _SentenceByUser = stringBuilder.ToString();
        CompleteSentence model = new CompleteSentence
        {
            SentenceByUser = stringBuilder.ToString(),
            OriginalSentence = OriginalSentence,
            Correct = _SentenceByUser.Equals(OriginalSentence),
            TimeToComplete = stopwatch.Elapsed
        };
        ds.CreateCompleteSentenceMMSE(model);
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.NameObjectMMSE);
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    private string[] ShuffleString(string[] array)
    {
        StringBuilder sb = new StringBuilder();
        try
        {
            var randomString = RandomString().ToArray();
            for (int i = 0; i < 5; i++)
            {
                int index = int.Parse(randomString[i].ToString());
                sb.Append(string.Format(@"{0} ", array[index].ToString()));
            }
            return sb.ToString().Trim().Split(' ');
        }
        catch (System.Exception)
        {
        }
        return sb.ToString().Trim().Split(' ');
    }

    private string RandomString()
    {
        const string chars = "01234";
        return new string(chars.OrderBy(r => random.Next()).ToArray());
    }



}




