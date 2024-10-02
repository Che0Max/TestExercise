using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;//������ ��� ���������
    //����������� ������� ��� ��������� � ����������� ����
    void OnCollisionEnter(Collision collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.8f);
        Destroy(this.gameObject);
        
    }
    
}
