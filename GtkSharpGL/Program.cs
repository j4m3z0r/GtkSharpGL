using System;
using Gtk;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Graphics;

namespace GtkSharpGL
{
	public class Program
	{
		public static void Main(String[] args) {

			Toolkit.Init ();
			Application.Init ();

			var window = new Window("GtkSharp GL Test Application");
			var glArea = new GLArea ();

			glArea.Realized += (object sender, EventArgs e) => {
				glArea.MakeCurrent();
				var vendor = GL.GetString(StringName.Vendor);
				Console.WriteLine($"Vendor is {vendor}");
			};

			window.Add (glArea);
			window.ShowAll ();

			Application.Run ();
		}
	}
}
