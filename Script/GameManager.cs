using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    blackOut blackoutUI;
    StandardUI standardUI;
    PlayerMoveMent player;

    public bool isPlayerNearNPC = false;
    public bool isPlayerPaused = false;

    void Awake() {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else
        {
            Destroy(this.gameObject);
        }
    }

    void Start() {
        blackoutUI = FindObjectOfType<blackOut>();
        standardUI = FindObjectOfType<StandardUI>();
        player = FindObjectOfType<PlayerMoveMent>();
    }

    public void InActivatePlayerMove()
    {
        player.moving = false;
    }

    public void ActivatePlayerMove()
    {
        player.moving = true;
    }

    public void SetPausePlayer(bool flag)
    {
        isPlayerPaused = flag;
    }

    public void VisualizeDialogUI()
    {
        standardUI.VisualizeDialogUI();
    }

    public void VanishingDialogUI()
    {
        standardUI.VanishingDialogUI();
    }
    
    
    public void SetDialogText(string text)
    {
        standardUI.SetDialogText(text);
    }
    public void SetSpeakerText(string text)
    {
        standardUI.SetSpeakerText(text);
    }

    public void SetOptionsText(string[] texts)
    {
        standardUI.SetOptionsText(texts);
        
    }

    public void showOptionUI(bool flag)
    {
        standardUI.showOptionUI(flag);
    }

    public void SelectOption(int index)
    {
        standardUI.SelectOption(index);
    }
}
