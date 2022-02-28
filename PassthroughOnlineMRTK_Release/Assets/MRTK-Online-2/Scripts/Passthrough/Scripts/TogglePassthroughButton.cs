using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePassthroughButton : MonoBehaviour
{
    //Toggleable GameObjects
    public GameObject ToggleObject;
    public GameObject SoundManager;
    public GameObject InteractableObject1;
    public GameObject InteractableObject2;
    public GameObject InteractableObject3;
    public GameObject InteractableObject4;
    public GameObject InteractableObject5;
    public GameObject InteractableObject6;
    public GameObject InteractableObject7;
    public GameObject InteractableObject8;

    //Functionallity to toggle each respective game object
    public void ToggleEnvironment()
    {
        if (ToggleObject.activeInHierarchy == true)
            ToggleObject.SetActive(false);
        else
            ToggleObject.SetActive(true);
    }

    public void ToggleSound()
    {
        if (SoundManager.activeInHierarchy == true)
            SoundManager.SetActive(false);
        else
            SoundManager.SetActive(true);
    }

    public void ToggleInteractableObject1()
    {
        if (InteractableObject1.activeInHierarchy == true)
            InteractableObject1.SetActive(false);
        else
            InteractableObject1.SetActive(true);
    }

    public void ToggleInteractableObject2()
    {
        if (InteractableObject2.activeInHierarchy == true)
            InteractableObject2.SetActive(false);
        else
            InteractableObject2.SetActive(true);
    }

    public void ToggleInteractableObject3()
    {
        if (InteractableObject3.activeInHierarchy == true)
            InteractableObject3.SetActive(false);
        else
            InteractableObject3.SetActive(true);
    }

    public void ToggleInteractableObject4()
    {
        if (InteractableObject4.activeInHierarchy == true)
            InteractableObject4.SetActive(false);
        else
            InteractableObject4.SetActive(true);
    }

    public void ToggleInteractableObject5()
    {
        if (InteractableObject5.activeInHierarchy == true)
            InteractableObject5.SetActive(false);
        else
            InteractableObject5.SetActive(true);
    }

    public void ToggleInteractableObject6()
    {
        if (InteractableObject6.activeInHierarchy == true)
            InteractableObject6.SetActive(false);
        else
            InteractableObject6.SetActive(true);
    }

    public void ToggleInteractableObject7()
    {
        if (InteractableObject7.activeInHierarchy == true)
            InteractableObject7.SetActive(false);
        else
            InteractableObject7.SetActive(true);
    }

    public void ToggleInteractableObject8()
    {
        if (InteractableObject8.activeInHierarchy == true)
            InteractableObject8.SetActive(false);
        else
            InteractableObject8.SetActive(true);
    }
}
