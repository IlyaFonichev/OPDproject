using UnityEngine;

public class Looting : MonoBehaviour
{
    //���������
    public delegate void AddScore(Score score, uint scoreValue);
    //�������: ��������� ���������� �����
    public AddScore addScore;

    //���� ������� �������� �����, �� ������ ��������� � ����������� ����
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            addScore?.Invoke(PlayerController.GetScoreOfPlayer(), 50);
        }
    }

    // ������������� �� ������� ���������� �����
    private void Start()
    {
        addScore += onAddScore;
    }

    // ������������ �� ������� ���������� �����
    private void OnDestroy()
    {
        addScore += onAddScore;
    }

    //��� ������ ������� ���������� ����� ����������� ��� �������
    private void onAddScore(Score score, uint scoreValue)
    {
        score.AddScore(scoreValue);
    }
}
