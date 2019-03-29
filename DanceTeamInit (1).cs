using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// This class generates and assigns names to the 2 dance teams in our dance off battle.
/// It also controls the number of dancers on each team via the inspector
/// It also uses the name generator to pass character names to the teams so they can initialise
/// 
/// TODO:
///     Generate unique team names for both teams and assign them via team_.SetTroupeName(str);
///     Use the nameGenerator to get enough names for the number of dancers on both teams and pass the required names via array to each team for init (InitaliseTeamFromNames)
/// #2
/// </summary>
public class DanceTeamInit : MonoBehaviour
{
    public DanceTeam teamA, teamB;

    public GameObject dancerPrefab;
    public int dancersPerSide = 3;
    public CharacterNameGenerator nameGenerator;

    private void OnEnable()
    {
        GameEvents.OnBattleInitialise += InitTeams;
    }
    private void OnDisable()
    {
        GameEvents.OnBattleInitialise -= InitTeams;
    }

   


    void InitTeams()
    {
        Debug.LogWarning("InitTeams called, needs to generate names for the teams and set them with teamA.SetTroupeName");

        // TODO for Week 7 - Do this third
        // - Set the troupe names for teamA and teamB
        //teamA.SetTroupeName(";kl"); // make better than this

        teamA.SetTroupeName("1");
        teamB.SetTroupeName("2");

        // - Get list of names from name generator
        // - Use the variable nameGenerator to generate names
        // - nameGenerator has a GenerateNames function

        CharacterName[] namesForA = nameGenerator.GenerateNames(dancersPerSide);
        CharacterName[] namesForB = nameGenerator.GenerateNames(dancersPerSide);



        // - Initialise the team names for team A and B
        // Example:
        // namesForA and namesForB should be based what you get
        //   from nameGenerator. 
        teamA.InitaliseTeamFromNames(dancerPrefab, 1, namesForA);
        teamB.InitaliseTeamFromNames(dancerPrefab, -1, namesForB);




        Debug.LogWarning("InitTeams called, needs to create character names via CharacterNameGenerator and get them into the team.InitaliseTeamFromNames");
    }
}
