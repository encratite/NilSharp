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

		public void Apply(Form applyForm)
		{
			applyForm.WindowState = Maximised ? FormWindowState.Maximized : FormWindowState.Normal;
			applyForm.Size = WindowSize;
			applyForm.Location = WindowOffset;
		}
	}
}
