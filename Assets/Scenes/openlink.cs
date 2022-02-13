using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openlink : MonoBehaviour
{
    public void OpenLinkFacebook()
    {
        Application.OpenURL("https://www.facebook.com/");
    }

    public void OpenLinkYoutube()
    {
        Application.OpenURL("https://www.youtube.com/");
    }

    public void OpenLinkUdg()
    {
        Application.OpenURL("https://www.udg.mx/");
    }
}
