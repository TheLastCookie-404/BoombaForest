using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LightSwitch : MonoBehaviour, IInteractable
{
    public Light m_Light;
    public LensFlareComponentSRP m_LenseFlare;
    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        m_Light.enabled = isOn;
    }

    // Update is called once per frame
    public string GetDescription()
    {
        if (isOn) return "Press [E] to turn <color=red>off</color> the light.";
        return "Press [E] to turn <color=green>on</color> the light.";
    }

    public void Interact()
    {
        isOn = !isOn;
        m_Light.enabled = isOn;
    }
}
