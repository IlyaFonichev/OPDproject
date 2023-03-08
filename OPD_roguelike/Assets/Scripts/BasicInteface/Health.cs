using UnityEngine;
using UnityEngine.SceneManagement;

public class Health
{
    //������� ��������, ����������� �������� ��� ����������
    [SerializeField] private uint _healthValue;
    [SerializeField] private uint _MaxHaelthValue;

    //����������� ��������
    public Health(uint health, uint maxHaelthValue)
    {
        _healthValue = health;
        _MaxHaelthValue = maxHaelthValue;
    }

    //setter ��� _healthValue
    public uint GetHealth() { return _healthValue; }

    //setter ��� _MaxHaelthValue
    public uint GetMaxHaelth() { return _MaxHaelthValue; }

    //��� ��������� ����� ���������� ��������, ����������� �� ���� �� ������
    public void Damage(uint damageCalue) 
    { 
        _healthValue -= damageCalue;
        if (_healthValue <= 0)
            SceneManager.LoadScene("EndScene");
        //����������� ��������� �������� ��� �����
        EventManager.changeHealthInterface?.Invoke(PlayerController.GetHealthOfPlayer());
    }

    //���������� ��������
    public void Heal(uint healValue) 
    { 
        _healthValue += healValue;
        //����������� ��������� �������� ��� �����
        EventManager.changeHealthInterface?.Invoke(PlayerController.GetHealthOfPlayer());
    }

    //������
    public void Kill() 
    { 
        _healthValue = 0;
        EventManager.changeHealthInterface?.Invoke(PlayerController.GetHealthOfPlayer());
    }
}
