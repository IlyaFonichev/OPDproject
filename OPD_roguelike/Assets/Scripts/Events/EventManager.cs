using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class EventManager : MonoBehaviour 
{
    //���������
    public delegate void TakeDamage(Health health, uint damage);
    //�������: ��������� ����� ������
    public static TakeDamage takeDamage;

    //���������
    public delegate void ChangeHealthInterface(Health health);
    //�������: ��������� ���������� ��������
    public static ChangeHealthInterface changeHealthInterface;

    //���������
    public delegate void ChangeScoreInterface(Score score);
    //�������: ��������� ���������� �����
    public static ChangeScoreInterface changeScoreInterface;

    //���������
    public delegate void AddScore(Score score, uint scoreValue);
    //�������: ��������� ���������� �����
    public AddScore addScore;

}

