using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Nil
{
	public class FormState
	{
		public bool Maximised;
		public Size WindowSize;
		public Point WindowOffset;

		public FormState()
		{
		}

		public void Load(Form loadForm)
		{
			Maximised = loadForm.WindowState == FormWindowState.Maximized;
			WindowSize = loadForm.Size;
			WindowOffset = loadForm.Location;
		}

		bool IsSane()
		{
			int
				x = WindowOffset.X,
				y = WindowOffset.Y;

			return
			!(
				x < 0 || y < 0 ||
				x > Screen.PrimaryScreen.WorkingArea.Width || y > Screen.PrimaryScreen.WorkingArea.Height
			);
		}

		public void Apply(Form applyForm)
		{
			if (IsSane())
			{
				applyForm.WindowState = Maximised ? FormWindowState.Maximized : FormWindowState.Normal;
				applyForm.Size = WindowSize;
				applyForm.Location = WindowOffset;
			}
		}
	}
}
