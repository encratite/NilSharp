using System;
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

			//it's set to -4, -4 in my theme
			const int windowsMaximisationMargin = 16;

			return
			!(
				x + WindowSize.Width < 0 || y + windowsMaximisationMargin < 0 ||
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
