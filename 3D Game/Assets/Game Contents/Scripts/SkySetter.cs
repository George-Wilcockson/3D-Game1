using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySetter : MonoBehaviour
{
    public Material daySky;
    public Material nightSky;
    public bool dayClicked = false;

    public void SetTheSky()
    {
        if(dayClicked)  { DaySkySet();}
        else { NightSkySet(); }
    }
    public void DaySkySet()
    {
        RenderSettings.skybox = daySky;
    }

    public void NightSkySet()
    {
        RenderSettings.skybox = nightSky;
    }
}
