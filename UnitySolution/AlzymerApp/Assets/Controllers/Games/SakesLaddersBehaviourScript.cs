using Assets.Controllers.Models;
using Assets.Controllers.Services;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = System.Random;
public class SakesLaddersBehaviourScript : MonoBehaviour
{

    #region Declarations
    private string RollPromote = @"Roll !!!";
    private int ImagePositionPoints = 0;
    public Text txtCounter;
    public Text txtRollPromote;
    public Image imagePiece;
    public Image diace;
    public Image ImageGameBackground;

    public Sprite diaceAnimation;
    public Sprite diace1;
    public Sprite diace2;
    public Sprite diace3;
    public Sprite diace4;
    public Sprite diace5;
    public Sprite diace6;
    public Sprite Celebration;

    private bool IsDiaceRolling = false;
    private Random random;
    private List<SnakesLaddersPositionViewModel> snakLaddersList = SnakesLaddersServices.GetList();
    #endregion
    private Stopwatch stopwatch = new Stopwatch();
    // Use this for initialization
    void Start()
    {
        stopwatch.Start();
        imagePiece.rectTransform.anchoredPosition = new Vector2(-193f, -303f);
        random = new Random();
        if (!IsDiaceRolling)
            txtRollPromote.text = RollPromote;
    }

    // Update is called once per frame
    void Update()
    {
        txtCounter.text = string.Format("{0}:{1}", stopwatch.Elapsed.Minutes.ToString("00"), stopwatch.Elapsed.Seconds.ToString("00"));
    }

    public void OnButtonRollClick()
    {
        txtRollPromote.text = string.Empty;
        IsDiaceRolling = true;
        int number = random.Next(1, 6);
        diace.sprite = diaceAnimation;
        ImagePositionPoints += number;
        diace.sprite = GetImage(number);
        IsDiaceRolling = false;

        if (ImagePositionPoints < 100)
        {
            var ladderObject = snakLaddersList.Where(i => i.Number.Equals(ImagePositionPoints)).FirstOrDefault();
            ImagePositionPoints = ladderObject.Number == ladderObject.NumberLand ? ImagePositionPoints : ladderObject.NumberLand;
            var NewObject = snakLaddersList.Where(i => i.Number.Equals(ImagePositionPoints)).FirstOrDefault();
            float positionX = NewObject.PostionX;
            float positionY = NewObject.PostionY;
            imagePiece.rectTransform.anchoredPosition = new Vector2(positionX, positionY);
            txtRollPromote.text = RollPromote;
        }
        else if (ImagePositionPoints == 100)
        {
            imagePiece.rectTransform.anchoredPosition = new Vector2(-193f, -303f);
            ImageGameBackground.sprite = Celebration;
        }
        else
        {
            ImagePositionPoints -= number;
        }
    }

    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    private Sprite GetImage(int number)
    {
        switch (number)
        {
            case 1:
                return diace1;
            case 2:
                return diace2;
            case 3:
                return diace3;
            case 4:
                return diace4;
            case 5:
                return diace5;
            case 6:
                return diace6;
        }
        return diaceAnimation;
    }
    //private 
}
