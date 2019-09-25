using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPill : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The amount of health that this pill restores")]
    private int m_HealthGain;
    public int HealthGain
    {
        get
        {
            return m_HealthGain;
        }
    }

    [SerializeField]
    [Tooltip("The amoount of Speed that this pill gives to player")]
    private float m_SpeedGain;
    public float SpeedGain
    {
        get
        {
            return m_SpeedGain;
        }
    }
    #endregion
}
