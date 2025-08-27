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
}
