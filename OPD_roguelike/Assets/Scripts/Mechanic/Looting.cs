using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looting : MonoBehaviour
{
    //������ �� �����������, ����� ������� ������
    EventManager em = new EventManager();

    //���� ������� �������� �����, �� ������ ��������� � ����������� ����
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            em.addScore?.Invoke(PlayerController.GetScoreOfPlayer(), 50);
        }
    }

    // ������������� �� ������� ���������� �����
    private void Start()
    {
        em.addScore += onAddScore;
    }

    // ������������ �� ������� ���������� �����
    private void OnDestroy()
    {
        em.addScore += onAddScore;
    }

    //��� ������ ������� ���������� ����� ����������� ��� �������
    private void onAddScore(Score score, uint scoreValue)
    {
        score.AddScore(scoreValue);
    }
}
