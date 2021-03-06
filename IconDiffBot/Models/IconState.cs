﻿using System.Collections.Generic;

namespace IconDiffBot.Models
{
	/// <summary>
	/// Represents a <see cref="Dmi"/> icon state
	/// </summary>
	sealed class IconState
	{
		/// <summary>
		/// The name of the state
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The number of directions in the state
		/// </summary>
		public int Dirs { get; set; }

		/// <summary>
		/// If the state rewinds after animating
		/// </summary>
		public bool Rewind { get; set; }

		/// <summary>
		/// The number of times the state loops if not infinite
		/// </summary>
		public int? LoopCount { get; set; }

		/// <summary>
		/// Number of frames in the state
		/// </summary>
		public int Frames { get; set; }

		/// <summary>
		/// Delays between frames in the state
		/// </summary>
		public List<float> FrameDelays { get; } = new List<float>();
	}
}