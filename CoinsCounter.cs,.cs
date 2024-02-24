using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    //Число собранных монет
    public int coins;

    //Метод, увеличивающий число монеток
    public void CollectCoins()
    {
        coins++;
    }
}
FireballAttack.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FireballAttack : MonoBehaviour
{
    //Префаб огненного шара и параметр Transform точки атаки
    public GameObject fireballPrefab;
    public Transform attackPoint;

    void Update()
    {
        //Если игрок кликает левой кнопкой мыши, то создаётся огненный шар
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
