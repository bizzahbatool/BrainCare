using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Diagnostics;
using Assets.Controllers.Models;
using System.Linq;
using UnityApp;
using UnityEngine.SceneManagement;
using System;

public class LocationBehaviourScript : MonoBehaviour {

    public Dropdown DdlCountries;
    public Dropdown DdlCites;
    public Text txtCounter;
    private Stopwatch stopwatch = new Stopwatch();
    private static List<Country> countries; 
    private static List<City> cities;
    TimeSpan TimeSpanDispay = new TimeSpan(0, 0, 30);
    DataService ds = new DataService(Utilities.DatabaseName);

    // Use this for initialization
    void Start ()
    {
        ds.UpdateSession(0, (int)UnityApp.Utilities.ScreensScenes.LocationMMSE);
        countries = Country.GetCountries();
        cities = City.GetCities();
        DdlCountries.AddOptions(countries.Select(i => i.name).ToList());
        string code = countries[DdlCountries.value].code;
        var citiesList = cities.Where(i => i.country.Equals(code)).Select(i => i.name).ToList();
        DdlCites.AddOptions(citiesList);
        stopwatch.Start();
    }
	
	// Update is called once per frame
	void Update () {
        var display = TimeSpanDispay - stopwatch.Elapsed;
        if (txtCounter != null)
            txtCounter.text = string.Format("{0}:{1}", display.Minutes.ToString("00"), display.Seconds.ToString("00"));
    }
    public void DdlCountriesOnValueChange()
    {
        DdlCites.options.Clear();
        string code = countries[DdlCountries.value].code;
        var citiesList = cities.Where(i => i.country.Equals(code)).Select(i=>i.name).ToList();
        DdlCites.AddOptions(citiesList);
    }

    public void SubmitOnClick()
    {
        // On Click Submit
        try
        {
            LocationMMSE model = new LocationMMSE
            {
                Country = countries[DdlCountries.value].name,
                City = cities[DdlCites.value].name,
                Time = stopwatch.Elapsed
            };
            ds.CreateLocationMMSE(model);
            SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.RecallImageMMSE);
        }
        catch (System.Exception)
        {
            
        }
    }
    public void OnHomeClick()
    {
        SceneManager.LoadScene((int)UnityApp.Utilities.ScreensScenes.Dashboard);
    }


}
