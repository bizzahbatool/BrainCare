namespace UnityApp
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;
    using ScreensScenes = UnityApp.Utilities.ScreensScenes;
    public class DashBoardHomeBehaviourScript : MonoBehaviour
    {
        public GameObject MocaPanel;
        public GameObject MmsePanel;
        public GameObject btnPrevious;
        public GameObject btnNext;

        DataService ds;
        UserSession userSession = new UserSession();
        // Use this for initialization
        void Start()
        {
            var previousButton = GameObject.Find("btnPrevious").GetComponent<Button>();
            ds = new DataService(Utilities.DatabaseName);
            userSession = ds.GetSession();
            previousButton.gameObject.SetActive(false);
            MocaPanel.gameObject.SetActive(false);
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

        public void OnNext()
        {
            // Current panel is mmse move to moca
            btnPrevious.gameObject.SetActive(true);
            btnNext.gameObject.SetActive(false);
            MocaPanel.gameObject.SetActive(true);
            MmsePanel.gameObject.SetActive(false);
        }

        public void OnPrevious()
        {
            // Current panel is MoCA move to mmse
            btnPrevious.gameObject.SetActive(false);
            btnNext.gameObject.SetActive(true);
            MocaPanel.gameObject.SetActive(false);
            MmsePanel.gameObject.SetActive(true);
        }
        public void OnClickStartMMSE()
        {
            if (userSession.MMSEScreen == 0)
            {
                SceneManager.LoadScene((int)ScreensScenes.LocationMMSE);
            }
            else
            {
                SceneManager.LoadScene(userSession.MMSEScreen);
            }
        }

        public void OnClickStartMoca()
        {
            if (userSession.MocaScreen == 0)
            {
                SceneManager.LoadScene((int)ScreensScenes.ConnectDotsMoca);
            }
            else
            {
                SceneManager.LoadScene(userSession.MocaScreen);
            }
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