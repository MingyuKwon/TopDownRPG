using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StandardUI : MonoBehaviour
{
    public static StandardUI instance = null;

    GameObject dialogPanel;
    GameObject speakerPanel;

    option[] Option;

    TextMeshProUGUI dialogText;
    TextMeshProUGUI speakerText;

    void Awake() {
         if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else
        {
            Destroy(this.gameObject);
        }

        dialogPanel = GetComponentInChildren<DialogPanel>().gameObject;
        speakerPanel = GetComponentInChildren<SpeakerPanel>().gameObject;

        dialogText = dialogPanel.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        speakerText = speakerPanel.gameObject.GetComponentInChildren<TextMeshProUGUI>();

        Option = dialogPanel.GetComponentsInChildren<option>();
    }

    void Start() {
        
        dialogText.text = "dialog";
        speakerText.text = "speaker";
        VanishingDialogUI();
    }

    public void showOptionUI(bool flag)
    {
        for(int i=0; i<Option.Length; i++)
        {
            Option[i].gameObject.SetActive(flag);
        }
    }


    public void VisualizeDialogUI()
    {
        dialogPanel.SetActive(true);
        speakerPanel.SetActive(true);
        showOptionUI(false);
    }

    public void VanishingDialogUI()
    {
        dialogPanel.SetActive(false);
        speakerPanel.SetActive(false);
    }

    public void SetDialogText(string text)
    {
        dialogText.text = text;
    }
    public void SetSpeakerText(string text)
    {
        speakerText.text = text;
    }

    public void SetOptionsText(string[] texts)
    {
        showOptionUI(true);
        for(int i=0; i<Option.Length; i++)
        {
            Option[i].changeText(texts[i]); 
        }
        
    }

    public void SelectOption(int index)
    {
        int optionCount = Option.Length;

        index = (int)Mathf.Clamp(index, 0, optionCount-1);
        for(int i=0; i<optionCount; i++)
        {
            if(i == index)
            {
                Option[i].Select(true);
            }else
            {
                Option[i].Select(false);
            }
        }
    }
}
