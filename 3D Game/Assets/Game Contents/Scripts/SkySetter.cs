using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySetter : MonoBehaviour
{
    public Material daySky;
    public Material nightSky;

    private void DaySkySet()
    {
        RenderSettings.skybox = daySky;
    }

    private void NightSkySet()
    {
        RenderSettings.skybox = nightSky;
    }
}
