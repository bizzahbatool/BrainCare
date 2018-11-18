using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using Assets.Controllers.Models;
using Assets.Controllers.Services;
using System.Linq;
using UnityEngine.SceneManagement;

public class MemoryTrainBehaviour : MonoBehaviour
{
    public Sprite Circle;
    public Sprite Square;
    public Sprite Star;
    public Sprite Triangle;

    public Text txtCircle;
    public Text txtSquare;
    public Text txtStar;
    public Text txtTriangle;
    public Text txtQuestion;
    
    public Image ImageDisplay;
    private bool TypeQuestion = false;
    private Stopwatch stopwatch = new Stopwatch();
    private List<MemoryTrainViewModel> list;
    private MemoryTrainViewModel MemoryTrainCurrent;
    private List<MemoryTrainDataEntity> lstDataEntity = new List<MemoryTrainDataEntity>();

    int counter = 0;
    // Use this for initialization
    void Start()
    {
        try
        {
            stopwatch.Start();
            list = MemoryTrainServices.GetShapes();
            UpdateImageAndTexts();
        }
        catch (System.Exception)
        {
            //
        }
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    // Update is called once per frame
    public void btnCircleOnCLick()
    {
        MemoryTrainCurrent = list[counter];
        lstDataEntity.Add(MemoryTrainServices.Validate(MemoryTrainCurrent, TypeQuestion, Shapes.Circle, Colors.Blue));
        UpdateImageAndTexts();
        counter++;
    }
    public void btnSquareOnCLick()
    {
        MemoryTrainCurrent = list[counter];
        lstDataEntity.Add(MemoryTrainServices.Validate(MemoryTrainCurrent, TypeQuestion, Shapes.Square, Colors.Red));
        UpdateImageAndTexts();
        counter++;
    }
    public void btnStarOnCLick()
    {
        MemoryTrainCurrent = list[counter];
        lstDataEntity.Add(MemoryTrainServices.Validate(MemoryTrainCurrent, TypeQuestion, Shapes.Star, Colors.Green));
        UpdateImageAndTexts();
        counter++;
    }
    public void btnTriangleOnCLick()
    {
        MemoryTrainCurrent = list[counter];
        lstDataEntity.Add(MemoryTrainServices.Validate(MemoryTrainCurrent, TypeQuestion, Shapes.Triangle, Colors.Yellow));
        UpdateImageAndTexts();
        counter++;
    }

    private Sprite GetSpriteToDisplay(string name)
    {

        switch (name)
        {
            case "Circle":
                return Circle;
            case "Square":
                return Square;
            case "Star":
                return Star;
            case "Triangle":
                return Triangle;
        }
        return null;
    }

    private void UpdateTexts(bool TypeQuestion)
    {
        if (TypeQuestion)// true Check shapes
        {
            txtCircle.text = Shapes.Circle.ToString();
            txtSquare.text = Shapes.Square.ToString();
            txtStar.text = Shapes.Star.ToString();
            txtTriangle.text = Shapes.Triangle.ToString();
            txtQuestion.text = string.Format("Select shape of the object?");
        }
        else
        {
            txtCircle.text = Colors.Blue.ToString();
            txtSquare.text = Colors.Red.ToString();
            txtStar.text = Colors.Green.ToString();
            txtTriangle.text = Colors.Yellow.ToString();
            txtQuestion.text = string.Format("Select Color of the object?");
        }

    }

    private void UpdateImageAndTexts()
    {
        MemoryTrainCurrent = list[counter];
        ImageDisplay.sprite = GetSpriteToDisplay(MemoryTrainCurrent.Name);
        TypeQuestion = TypeQuestion ? false : true;
        UpdateTexts(TypeQuestion);
    }
}
