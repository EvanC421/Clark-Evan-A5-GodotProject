using Godot;
using System;

public partial class EnemySpawn1 : Node2D
{
	[Export]
	private int DoesEnemySpawn;

	[Export]
	private PackedScene PackedScene;

	private RandomNumberGenerator RNG = new RandomNumberGenerator();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		DoesEnemySpawn = RNG.RandiRange(0, 500); // chances of enemy to spawn each frame
		if (DoesEnemySpawn == 10) // enemy spawns
		{
			Node2D enemy = PackedScene.Instantiate<Node2D>();
			this.AddChild(enemy);
		}
	}
}
