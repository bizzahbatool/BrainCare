using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AnimalDraggingBehaviourScript : MonoBehaviour
{

    public Text txtCounter;
    float OffsetXAxis;
    float OffsetYAxis;
    Stopwatch stopwatch = new Stopwatch();
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    DataService ds = new DataService(Utilities.DatabaseName);
    public AudioClip impactBird;
    public AudioClip impactDog;
    public AudioClip impactFish;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        stopwatch.Start();
        //ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.AnimalDragging);

    }

    // Update is called once per frame
    void Update () {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));

    }
    public void BeginFishDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }

    public void OnFishDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }

    public void BeginBirdDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }

    public void OnBirdDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }

    public void BeginDogDrag()
    {
        OffsetXAxis = transform.position.x - Input.mousePosition.x;
        OffsetYAxis = transform.position.y - Input.mousePosition.y;
    }
    public void OnDogDrag()
    {
        transform.position = new Vector3(
            OffsetXAxis + Input.mousePosition.x,
            OffsetYAxis + Input.mousePosition.y
            );
    }
    public void OnSubmitButtonClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.AnimalDraggingWithVoice);
    }

    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }
    public void OnBtnFishSound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(impactFish, 0.8F);
    }
    public void OnBtnDogSound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(impactDog, 0.8F);
    }
    public void OnBtnBirdSound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(impactBird, 0.8F);
    }
    private void ValidatePosition()
    {
        
    }


}
