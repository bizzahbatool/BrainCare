using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScreensScenes = UnityApp.Utilities.ScreensScenes;
namespace UnityApp
{
    public class Screen1Menu : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnClickLearnAboutApp()
        {
            SceneManager.LoadScene((int)ScreensScenes.LoginForm);
        }

        public void OnClickFitnessTest()
        {
            SceneManager.LoadScene((int)ScreensScenes.Dashboard);
        }
    }
}