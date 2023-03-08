using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //��, ����� ����
    private Collider _currentCollider;

    //��� ������� � ����
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //������� ��������� �����
            EventManager.takeDamage?.Invoke(PlayerController.GetHealthOfPlayer(), 1);
        }
    }

    // ������������� �� ������� ��������� �����
    private void Start() { EventManager.takeDamage += onTakeDamage; }

    // ������������ �� ������� ��������� �����
    private void OnDestroy() { EventManager.takeDamage -= onTakeDamage; }

    //��� ������ ������ ��������� ����� ����������� ��� �������
    private void onTakeDamage(Health health, uint damage)
    {
        health.Damage(damage);
    }
}
