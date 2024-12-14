using Godot;
using System;

public partial class Hitbox : Area2D
{

	[Export]
	private ScoreUI ScoreUI;
	[Export]
	private int Points = 1;

	private void OnBodyEntered(Node2D body)
	{
		ScoreUI.AddScore(Points);
	}
}
