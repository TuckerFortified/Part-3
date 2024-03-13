using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{

    public TextMeshProUGUI Text;
    public static CharacterControl Instance;

    private void Start()
    {
        Instance = this; 
    }
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        CharacterControl.Instance.Text.text = villager.GetType().ToString();
    }
    
}
