using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class Player : RigidBody2D
{
	[Export]
	private float Speed = 400;
	[Export]
	private float JumpHeight = 50;

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
		if (Input.IsActionPressed("right"))
		{
			this.ApplyForce(Vector2.Right * Speed);
		}

		if (Input.IsActionPressed("left"))
		{
			this.ApplyForce(Vector2.Left * Speed);
		}

		if (Input.IsActionJustPressed("jump"))
		{
			this.ApplyImpulse(Vector2.Up * JumpHeight);
		}

		if (Input.IsActionJustPressed("shoot")) //player shoots laser
		{
			Node2D laser = LaserShot.Instantiate<Node2D>();
			this.AddChild(laser);
		}
	}

}
