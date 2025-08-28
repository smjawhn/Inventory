using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public static UIManger instance { get; private set; }

    [SerializeField] private UIMainMenu uiMainmenu;
    [SerializeField] private UIStatus uistatus;
    [SerializeField] private UIInventory uiInventory;
    

    public UIMainMenu MainMenu => uiMainmenu;
    public UIStatus Status => uistatus;
    public UIInventory Inventory => uiInventory;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

    }


    public void ShowStatus()
    {
        uiMainmenu.StatusBtn.gameObject.SetActive(false);
        uiMainmenu.InventoryBtn.gameObject.SetActive(false);
        uistatus.gameObject.SetActive(true);
        
    }
    public void ShowInventory()
    {
        uiMainmenu.StatusBtn.gameObject.SetActive(false);
        uiMainmenu.InventoryBtn.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(true);
    }
    public void BacktoMain()
    {
        uistatus.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(false);
        uiMainmenu.StatusBtn.gameObject.SetActive(true);
        uiMainmenu.InventoryBtn.gameObject.SetActive(true);
    }
}
