using UnityEngine;

public class Improvement : MonoBehaviour
{
    [SerializeField]
    private Ability ability;

    private void OnMouseDown()//��� ���, ��� ������������. �������� �� OnTriggerEnter
    {
        AbilityUI.AddAbility(ability);
        Destroy(gameObject);
    }
}
