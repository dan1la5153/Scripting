using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro


public class playerUI : MonoBehaviour
{
    public player;
    public textMeshProGUI coinsCounterText
    public Slider healtSlider;
    // Start is called before the first frame update
    
    
    // Update is called once per frame
    void Update()
    {
        //обновляем значения здоровья игрока
        healtSlider.maxValue = player.maxHealth;
        healtSlider.value = player.health

            //обновляем текст с копичеством монеток 
            coinsCounterText.text = player.coins.ToString();
    }
}
