using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour
{

    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject hpSlider;


    private void Awake()
    {
        settingsPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (settingsPanel.activeInHierarchy)
            {
                settingsPanel.SetActive(false);
                hpSlider.SetActive(true);
            }
            else
            {
                settingsPanel.SetActive(true);
                hpSlider.SetActive(false);
            }
        }
    }
}
