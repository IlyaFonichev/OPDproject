using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class EventManager : MonoBehaviour 
{
    //���������
    public delegate void TakeDamage(HealthOfPlayer health, uint damage);
    //�������: ��������� ����� ������
    public static TakeDamage takeDamage;

    //���������
    public delegate void ChangeHealthInterface(HealthOfPlayer health);
    //�������: ��������� ���������� ��������
    public static ChangeHealthInterface changeHealthInterface;

    //���������
    public delegate void ChangeScoreInterface(Score score);
    //�������: ��������� ���������� �����
    public static ChangeScoreInterface changeScoreInterface;

}

