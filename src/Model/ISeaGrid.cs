
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
/// <summary>
/// The ISeaGrid defines the read only interface of a Grid. This
/// allows each player to see and attack their opponents grid.
/// </summary>
public interface ISeaGrid
{


	int Width { get; }

	int Height { get; }
	/// <summary>
	/// Indicates that the grid has changed.
	/// </summary>

	event EventHandler Changed;
	/// <summary>
	/// Provides access to the given row/column
	/// </summary>
	/// <param name="row">the row to access</param>
	/// <param name="column">the column to access</param>
	/// <value>what the player can see at that location</value>
	/// <returns>what the player can see at that location</returns>

	TileView this[int row, int col] { get; }
	/// <summary>
	/// Mark the indicated tile as shot.
	/// </summary>
	/// <param name="row">the row of the tile</param>
	/// <param name="col">the column of the tile</param>
	/// <returns>the result of the attack</returns>
	AttackResult HitTile(int row, int col);

	/// <summary>
	/// IsDesirableTarget returns true when a given row or column contains an enemy
	/// ship.
	/// </summary>
	/// <param name="row">the row at which is being shot</param>
	/// <param name="col">the cloumn at which is being shot</param>
	/// <returns>A boolean true if an enemy ship is within the row or column, otherwise false.</returns>
	bool IsDesirableTarget(int row, int col);
}
