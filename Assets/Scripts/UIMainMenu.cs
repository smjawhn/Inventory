using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    [Header("Character Info")]
    [SerializeField] private TMP_Text nickNameTxt;
    [SerializeField] private TMP_Text levelTxt;
    [SerializeField] private TMP_Text expTxt;
    [SerializeField] private TMP_Text haveGoldTxt;

    public Button StatusBtn => statusBtn;
    public Button InventoryBtn => inventoryBtn;
    public TMP_Text nickNameText => nickNameTxt;
    public TMP_Text levelText => levelTxt;
    public TMP_Text expText => expTxt;
    public TMP_Text haveGoldText => haveGoldTxt;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    public void OpenMainmenu()
    {
        UIManger.instance.BacktoMain();
    }

    public void OpenStatus()
    {
        UIManger.instance.ShowStatus();
    }

    public void OpenInventory()
    {
        UIManger.instance.ShowInventory();
    }
}
