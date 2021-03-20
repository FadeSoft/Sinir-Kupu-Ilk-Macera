using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ButtonScene12345 : MonoBehaviour
{
    //////////////////////////// MENÜ//////////////////////////////
    public void MenuDön()
    {
        Application.LoadLevel(1);
    }  
    public void Oyna()
    {
        Application.LoadLevel(2);
    }
    public void hardcoremodepısode()
    {
        Application.LoadLevel(55);

    }
    public void REHBER()
    {
        Application.LoadLevel(44);

    }


    /// /////////////////////////////////HAKKINDA//////////////////


    private const string FACEBOOK_URL = "https://www.facebook.com/fadesoftware/";
    private const string TWiTTER_URL = "https://twitter.com/FADESOFTWAREX/";
    private const string WEBSİTE_URL = "https://http://www.fadesoftware.com";
    private const string GMAIL_URL = "mailto:softwarefade@gmail.com";

    public void OnFaceClick()
    {
        Application.OpenURL(FACEBOOK_URL);

    }
    public void OnTwitClick()
    {
        Application.OpenURL(TWiTTER_URL);
    }
    public void OnWebsiteClick()
    {
        Application.OpenURL(WEBSİTE_URL);
    }
    public void OnGmailClick()
    {
        Application.OpenURL(GMAIL_URL);

    }
}
