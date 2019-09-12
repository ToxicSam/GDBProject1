﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackInfo
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("A name for this attack")]
    private string m_Name;
    public string AttackName
    {
        get
        {
            return m_Name;
        }
    }

    [SerializeField]
    [Tooltip("The button to press that will use this attack.")]
    private string m_Button;
    public string Button
    {
        get
        {
            return m_Button;
        }
    }

    [SerializeField]
    [Tooltip("The trigger string to use to activate this attack in the animator")]
    private string m_TriggerName;
    public string TriggerName
    {
        get
        {
            return m_TriggerName;
        }
    }

    [SerializeField]
    [Tooltip("The prefab of the game object representing the ability")]
    private GameObject m_AbilityGo;
    public GameObject AbilityGo
    {
        get
        {
            return m_AbilityGo;
        }
    }

    [SerializeField]
    [Tooltip("Where to spawn the ability game object with respect to the palyer")]
    private Vector3 m_Offset;
    public Vector3 Offset
    {
        get
        {
            return m_Offset;
        }
    }

    [SerializeField]
    [Tooltip("How long to wait before this attack should be activaetd after the button is presser")]
    private float m_WindUpTime;
    public float WindUpTime
    {
        get
        {
            return m_WindUpTime;
        }
    }

    [SerializeField]
    [Tooltip("How long to wait before the player can do anything again")]
    private float m_FrozenTime;
    public float FrozenTime
    {
        get
        {
            return m_FrozenTime;
        }
    }

    [SerializeField]
    [Tooltip("How long the player has to wait before this ability can be used again")]
    private float m_Cooldown;

    [SerializeField]
    [Tooltip("The amount of heal this ability costs")]
    private float m_HealthCost;
    public float HealthCost
    {
        get
        {
            return m_HealthCost;
        }
    }

    [SerializeField]
    [Tooltip("The color to change when using this ability")]
    private Color m_Color;
    public Color AbilityColor
    {
        get
        {
            return m_Color;
        }
    }
    #endregion


    #region Public Variables
    public float Cooldown
    {
        get;
        set;
    }
    #endregion

    #region Cooldown Methods
    public void resetCooldown()
    {
        Cooldown = m_Cooldown;
    }

    public bool IsReady()
    {
        return Cooldown <= 0;
    }
    #endregion
}