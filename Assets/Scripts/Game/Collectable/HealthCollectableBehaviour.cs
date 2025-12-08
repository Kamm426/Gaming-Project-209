using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthCollectableBehaviour : MonoBehaviour, ICollectableBehaviour
{

    [SerializeField]
    private int _healthAmount;

    public void OnCollected(GameObject player)
    {
        player.GetComponent<HealthController>().AddHealth(_healthAmount);

    }
}
