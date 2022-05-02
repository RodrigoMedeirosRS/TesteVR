using Godot;
using System;

public class Main : Spatial
{
	public override void _Ready()
	{
		var arvr_interface = ARVRServer.FindInterface("Native mobile");
		if (arvr_interface != null && arvr_interface.Initialize())
			GetViewport().Arvr = true;
	}
}
