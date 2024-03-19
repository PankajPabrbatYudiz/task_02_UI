using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    [SerializeField] private Canvas LoginPage;
    [SerializeField] private Canvas RegistrationPage;
    [SerializeField] private Canvas GamePlay;
    [SerializeField] private Canvas MainMenue;
    [SerializeField] private Canvas PointRummy;
    [SerializeField] private Canvas Exite;
   // public Button loginbutton;

    public void Start()
    {
        Debug.Log("hello Start Method is call");
       
        ShowLoginpage();
      
    }
    public void ShowLoginpage()
    {
        LoginPage.GetComponent<Canvas>().enabled = true;
       
        RegistrationPage.GetComponent<Canvas>().enabled = false;
        GamePlay.GetComponent<Canvas>().enabled = false;
        MainMenue.GetComponent<Canvas>().enabled = false;
        PointRummy.GetComponent<Canvas>().enabled = false;
        Exite.GetComponent<Canvas>().enabled = false;     
    }
    public void ShowRegistrationpage()
    {
        LoginPage.GetComponent<Canvas>().enabled = false;
        RegistrationPage.GetComponent<Canvas>().enabled = true;
        GamePlay.GetComponent<Canvas>().enabled = false;
        MainMenue.GetComponent<Canvas>().enabled = false;
        PointRummy.GetComponent<Canvas>().enabled = false;
        Exite.GetComponent<Canvas>().enabled = false;

    }

    public void ShowGameplay()
    {
        LoginPage.GetComponent<Canvas>().enabled = false;
        RegistrationPage.GetComponent<Canvas>().enabled = false;
        GamePlay.GetComponent<Canvas>().enabled = true;
        MainMenue.GetComponent<Canvas>().enabled = false;
        PointRummy.GetComponent<Canvas>().enabled = false;
        Exite.GetComponent<Canvas>().enabled = false;
    }
    public void ShowMainMenue()
    {
        LoginPage.GetComponent<Canvas>().enabled = false;
        RegistrationPage.GetComponent<Canvas>().enabled = false;
        GamePlay.GetComponent<Canvas>().enabled = false;
        PointRummy.GetComponent<Canvas>().enabled = true;
        MainMenue.GetComponent<Canvas>().enabled = true;
       
        Exite.GetComponent<Canvas>().enabled = false;
    }
    public void ShowPointRummy()
    {
        LoginPage.GetComponent<Canvas>().enabled = false;
        RegistrationPage.GetComponent<Canvas>().enabled = false;
        GamePlay.GetComponent<Canvas>().enabled = false;
        MainMenue.GetComponent<Canvas>().enabled = false;
        PointRummy.GetComponent<Canvas>().enabled = true;
        Exite.GetComponent<Canvas>().enabled = false;

    }
    public void shoiwExite()
    {
        LoginPage.GetComponent<Canvas>().enabled = false;
        RegistrationPage.GetComponent<Canvas>().enabled = false;
        GamePlay.GetComponent<Canvas>().enabled = false;
        MainMenue.GetComponent<Canvas>().enabled = false;
        PointRummy.GetComponent<Canvas>().enabled = false;
        Exite.GetComponent<Canvas>().enabled = true;

    }
}
