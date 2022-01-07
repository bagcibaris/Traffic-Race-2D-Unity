using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public AudioSource clickSound;
    public GameObject quitPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   //çýkýþ
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            quitPanel.SetActive(true);
        }
    }

    public void ClickSound()
    {
        clickSound.Play();
    }

    public void Play()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
