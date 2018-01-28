﻿using UnityEngine;

public class Entity : MonoBehaviour
{
	public const int TEAM_A_ID = 0;
	public const int TEAM_B_ID = 1;

	public int TeamID { get { return teamID; } }
	public int PlayerID { get { return playerID; } }
	public bool Reflective { get { return reflective; } }

	[SerializeField]
	private int teamID = -1;
	[SerializeField]
	private int playerID = -1;
	[SerializeField]
	private bool reflective = false;

	public void SetEntityProperties(int teamID, int playerID, bool reflective)
	{
		this.teamID = teamID;
		this.playerID = playerID;
		this.reflective = reflective;
	}

}