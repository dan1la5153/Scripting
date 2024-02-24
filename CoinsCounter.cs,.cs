using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    //����� ��������� �����
    public int coins;

    //�����, ������������� ����� �������
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
    //������ ��������� ���� � �������� Transform ����� �����
    public GameObject fireballPrefab;
    public Transform attackPoint;

    void Update()
    {
        //���� ����� ������� ����� ������� ����, �� �������� �������� ���
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
