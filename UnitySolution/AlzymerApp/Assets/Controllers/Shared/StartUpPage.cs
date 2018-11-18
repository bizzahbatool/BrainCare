using System.Collections;
using System.Collections.Generic;
using UnityApp;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScreensScenes = UnityApp.Utilities.ScreensScenes;
namespace UnityApp
{
    public class StartUpPage : MonoBehaviour
    {


        // Use this for initialization
        void Start()
        {
            var ds = new DataService(Utilities.DatabaseName,true);
            //ds.CreateDemoUser();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnGetStartedButtonClick()
        {
            SceneManager.LoadScene((int)ScreensScenes.LoginAuthMainForm);
        }

        public void OnAlreadyMemeberButton()
        {
            SceneManager.LoadScene((int)ScreensScenes.LoginForm);
        }
    }

}
