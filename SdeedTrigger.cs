using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdeedTrigger : MonoBehaviour
{
    public float speedFactor = 20.5f;
    
    void OnTriggerEnter(Collider other)
   
} 

    void onTiggerExit(Collider other)
{
    //���������� �������� ���� ������
    other.GetComponent<FirstPersonMovement>().runSpeed*=speedFactor;
    }
void onTiggerExit(Collider other)
{
    //��������� �������� ���� ������
    other.GetComponent<FirstPersonMovement>().runSpeed/=speedFactor;
}

}