using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject realityBackground, realityGround, realityPlatform,
        parallelBackground, parallelGround, parallelPlatform, audio1, audio2;

    [SerializeField]
    private KeyCode themeSwitchKey;

    //false for reality, true for parallel
    private bool activeTheme;

    void Start() => ActivateReality();

    void Update()
    {
        if (Input.GetKeyDown(themeSwitchKey))
        {
            if (!activeTheme)
                ActivateParallel();
            else
                ActivateReality();
        }
    }

    private void ActivateReality()
    {
        realityBackground.SetActive(true);
        realityGround.SetActive(true);
        realityPlatform.SetActive(true);
        audio1.GetComponent<AudioSource>().volume = 0.2f;
        audio2.GetComponent<AudioSource>().volume = 0f;
        parallelBackground.SetActive(false);
        parallelGround.SetActive(false);
        parallelPlatform.SetActive(false);

        activeTheme = false;
    }

    private void ActivateParallel()
    {
        realityBackground.SetActive(false);
        realityGround.SetActive(false);
        realityPlatform.SetActive(false);
        audio1.GetComponent<AudioSource>().volume = 0f;
        audio2.GetComponent<AudioSource>().volume = 0.2f;
        parallelBackground.SetActive(true);
        parallelGround.SetActive(true);
        parallelPlatform.SetActive(true);

        activeTheme = true;
    }
}
