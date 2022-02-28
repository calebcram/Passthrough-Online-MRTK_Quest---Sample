using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughManager : MonoBehaviour
{
    public OVRPassthroughLayer passthrough;
    public OVRInput.Button button;
    public OVRInput.Controller controller;
    public List<Gradient> colorMapGradient;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button, controller))
        {
            passthrough.hidden = !passthrough.hidden;
        }
    }

    public void SetOpacity(float value)
    {
        passthrough.textureOpacity = value;
    }

    public void SetColorMapGradient(int index)
    {
        passthrough.colorMapEditorGradient = colorMapGradient[index];
    }

    public void SetBrightness(float value)
    {
        passthrough.colorMapEditorBrightness = value;
    }
    public void SetContrast(float value)
    {
        passthrough.colorMapEditorContrast = value;
    }
    public void SetPosterize(float value)
    {
        passthrough.colorMapEditorPosterize = value;
    }

    public void SetEdgeRendering(bool value)
    {
        passthrough.edgeRenderingEnabled = value;
    }

    public void SetEdgeRed(float value)
    {
        Color newColor = new Color(value, passthrough.edgeColor.g, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor;
    }

    public void SetEdgeGreen(float value)
    {
        Color newColor = new Color(passthrough.edgeColor.r, value, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor;
    }
    public void SetEdgeBlue(float value)
    {
        Color newColor = new Color(passthrough.edgeColor.r, passthrough.edgeColor.g, value);
        passthrough.edgeColor = newColor;
    }
}
