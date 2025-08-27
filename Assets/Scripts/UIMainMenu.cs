using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [Header("Button")]
    public Button statusBtn;
    public Button inventoryBtn;

    [Header("Character Info")]
    public TMP_Text nickNameTxt;
    public TMP_Text levelTxt;
    public TMP_Text expTxt;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    public void OpenMainmenu()
    {
        statusBtn.gameObject.SetActive(true);
        inventoryBtn.gameObject.SetActive(true);
        
    }

    public void OpenStatus()
    {
        statusBtn.gameObject.SetActive(false);
        inventoryBtn.gameObject.SetActive(false);
        

    }

    public void OpenInventory()
    {
        statusBtn.gameObject.SetActive(false);
        inventoryBtn.gameObject.SetActive(false);
        
    }
}
