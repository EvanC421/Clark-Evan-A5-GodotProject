using Godot;
using System;

public partial class ScoreUI : Label
{
	private int score;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		Text = $"score: {score}";
	}

	public void AddScore(int points)
	{
		score += points;
		UpdateDisplay();
	}

}
