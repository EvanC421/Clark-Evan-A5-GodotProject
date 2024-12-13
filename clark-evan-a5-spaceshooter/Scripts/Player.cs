using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class Player : Node2D
{
	[Export]
	private float Speed = 400;

	[Export]
	private PackedScene LaserShot;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Player's gravity variables
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float moveX = Input.GetAxis("left", "right") * Speed * (float)delta;
		Translate(new Vector2(moveX, 0));

		if (Input.IsActionJustPressed("shoot")) //player shoots laser
		{
			Node2D laser = LaserShot.Instantiate<Node2D>();
			this.AddChild(laser);
		}
	}
}
