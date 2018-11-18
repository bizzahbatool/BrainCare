using Assets.Controllers.Models;
using Assets.Controllers.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = System.Random;
using TimeSpan = System.TimeSpan;
public class RecognizeAnimalBehaviourScript : MonoBehaviour
{

    public Sprite Lion;
    public Sprite Tiger;
    public Sprite Horse;
    public Sprite Dog;
    public Sprite Cow;
    public Sprite Cat;

    public Text btnOption1;
    public Text btnOption2;
    public Text btnOption3;
    public Text btnOption4;
    public Image ImageAnimal;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    private List<Animal> AnimalsList = new List<Animal>();
    private Animal animalSelected;
    Stopwatch stopwatch = new Stopwatch();
    Random random = new Random();
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    DataService ds = new DataService(Utilities.DatabaseName);
    public Text txtCounter;
    // Use this for initialization
    void Start()
    {
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.RecognizeAnimalMoca);
        AnimalsList = AnimalServices.GetAnimals().OrderBy(i => i.Counter).Take(4).ToList();
        animalSelected = AnimalsList[0];
        ImageAnimal.sprite = GetSpriteToDisplay((int)animalSelected.AnimalType);
        ds = new DataService(Utilities.DatabaseName);
        stopwatch.Start();
        PopulateOptions();
    }

    // Update is called once per frame
    void Update()
    {

        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }
    public void OnClickbtnOption1()
    {
        btn1.colors = new ColorBlock();
        CreateAnimalEntity(Validate(ConvertStringToEnum(btnOption1.text)), btnOption1.text);
    }

    public void OnClickbtnOption2()
    {
        btn2.colors = new ColorBlock();
        CreateAnimalEntity(Validate(ConvertStringToEnum(btnOption2.text)), btnOption2.text);
    }

    public void OnClickbtnOption3()
    {
        btn3.colors = new ColorBlock();
        CreateAnimalEntity(Validate(ConvertStringToEnum(btnOption3.text)), btnOption3.text);
    }

    public void OnClickbtnOption4()
    {
        btn4.colors = new ColorBlock();
        CreateAnimalEntity(Validate(ConvertStringToEnum(btnOption4.text)), btnOption4.text);
    }
    public void OnSUbmitClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.DragFruitsMoca);
    }
    Animal Validate(Animals type)
    {
        animalSelected.Correct = animalSelected.AnimalType == type;
        return animalSelected;
    }
    void CreateAnimalEntity(Animal animal,string SelectedAnimal)
    {
        var model = new AnimalRecognize();
        model.OptionAnimalName = SelectedAnimal;
        model.OriginalAnimalName = animal.AnimalType.ToString();
        model.TimeToComplete = stopwatch.Elapsed;
        model.Correct = animal.Correct;
        ds.CreateAnimalRecognize(model);
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    Sprite GetSpriteToDisplay(int Selected)
    {
        if (Selected == ((int)Animals.Snake)) return Cat;
        if (Selected == ((int)Animals.Bear)) return Cow;
        if (Selected == ((int)Animals.Dog)) return Dog;
        if (Selected == ((int)Animals.Fox)) return Horse;
        if (Selected == ((int)Animals.Shark)) return Lion;
        if (Selected == ((int)Animals.Turtle)) return Tiger;
        return Cat;
    }
    Animals ConvertStringToEnum(string animal)
    {
        if (animal.Equals("Cat")) return Animals.Snake;
        else if (animal.Equals("Cow")) return Animals.Bear;
        else if (animal.Equals("Dog")) return Animals.Dog;
        else if (animal.Equals("Horse")) return Animals.Fox;
        else if (animal.Equals("Lion")) return Animals.Shark;
        else return Animals.Turtle;
    }
    void PopulateOptions()
    {
        int rand = random.Next(0, 100);
        if (rand < 25)
        {
            btnOption1.text = AnimalsList[0].Name;
            btnOption2.text = AnimalsList[1].Name;
            btnOption3.text = AnimalsList[2].Name;
            btnOption4.text = AnimalsList[3].Name;
        }
        else if (rand <50)
        {
            btnOption2.text = AnimalsList[0].Name;
            btnOption1.text = AnimalsList[1].Name;
            btnOption3.text = AnimalsList[2].Name;
            btnOption4.text = AnimalsList[3].Name;
        }
        else if (rand < 75)
        {
            btnOption1.text = AnimalsList[0].Name;
            btnOption3.text = AnimalsList[1].Name;
            btnOption2.text = AnimalsList[2].Name;
            btnOption4.text = AnimalsList[3].Name;
        }
        else if (rand < 100)
        {
            btnOption1.text = AnimalsList[0].Name;
            btnOption2.text = AnimalsList[1].Name;
            btnOption4.text = AnimalsList[2].Name;
            btnOption3.text = AnimalsList[3].Name;
        }
    }
}
