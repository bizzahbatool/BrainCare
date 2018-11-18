using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ScreensScenes = UnityApp.Utilities.ScreensScenes;
namespace UnityApp
{

    public class DashBoardGamesBehaviourScript : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void OnClickHome()
        {
            SceneManager.LoadScene((int)ScreensScenes.Dashboard);
        }
        public void OnClickGame()
        {
            SceneManager.LoadScene((int)ScreensScenes.DashboardGames);
        }
        public void OnClickStats()
        {
            SceneManager.LoadScene((int)ScreensScenes.DashboardStats);
        }
        public void OnClickMore()
        {
            SceneManager.LoadScene((int)ScreensScenes.DashboardMore);
        }

        public void OnClickSnakesTest()
        {
            SceneManager.LoadScene((int)ScreensScenes.SnakesAndLaddersGame);
        }

        public void OnClickCognativeTest()
        {
            SceneManager.LoadScene((int)ScreensScenes.MemoryTrainGame);
        }
    }
}