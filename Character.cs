﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a single character, their stats, name and current mojo (or hp) in the dance battle.
/// 
/// TODO:
///     Initialise stats for the character that will be used to determine their victory in dance offs.
///     You may wish or need to add additional stats here for use in the fight (FightManager)
///     May need to handle the loss of mojo when loosing a fight
/// </summary>
public class Character : MonoBehaviour
{
    public CharacterName charName;

    [Range(0.0f,1.0f)]
    public float mojoRemaining = 1;

    [Header("Stats")]
    public int availablePoints = 10;

    public int level;
    public int xp;
    public int style, luck, rhythm;


    [Header("Related objects")]
    public DanceTeam myTeam;

    public bool isSelected;

    [SerializeField]
    protected TMPro.TextMeshPro nickText;


    void Awake()
    {
        InitialStats();
    }

    public void InitialStats()
    {
        // Do this one first!
        // This will be similar to the code from InitialStats in
        //      StatsGenerator
        rhythm = Random.Range(1, 6);
        style = Random.Range(1, 5);
        luck = Random.Range(1, 4);
        level = 1;
        xp = 0;


        Debug.Log(rhythm);
        Debug.Log(style);
        Debug.Log(luck);
        Debug.Log(level);
        Debug.Log(xp);
    }

    public void AssignName(CharacterName characterName)
    {
        charName = characterName;
        if(nickText != null)
        {
            nickText.text = charName.nickname;
            nickText.transform.LookAt(Camera.main.transform.position);
            //text faces the wrong way so
            nickText.transform.Rotate(0, 180, 0);
        }
    }
}
