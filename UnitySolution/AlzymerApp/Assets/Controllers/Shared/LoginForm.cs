using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ScreensScenes = UnityApp.Utilities.ScreensScenes;
namespace UnityApp
{
    public class LoginForm : MonoBehaviour
    {
        string UserName = string.Empty;
        string Password = string.Empty;
        string ValidationMessage = @"Login unsuccessful";
        DataService ds;
        // Use this for initialization
        void Start()
        {
            ds = new DataService(Utilities.DatabaseName);
            ds.CreateDemoUser();
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetUserName(string userName)
        {
            UserName = userName;
        }

        public void SetPassword(string password)
        {
            Password = password;
        }
        
        public void OnLoginButtonPressed()
        {
            
            //Get Users from Database
            try
            {
                
                if (ds.GetUser(UserName, Password) != null)
                {
                    ds.CreateSession(UserName);
                    Debug.Log(string.Format("Login Succefull"));
                    SceneManager.LoadScene((int)ScreensScenes.Screen1Menu);
                }
                else
                {
                    Text textObject = GameObject.Find("txtValidationMessage").GetComponent<Text>();
                    textObject.text = ValidationMessage;
                }
            }
            catch (Exception exp)
            {
                Text textObject = GameObject.Find("txtValidationMessage").GetComponent<Text>();
                textObject.text = exp.Message.ToString();
            }

        }
    }
}