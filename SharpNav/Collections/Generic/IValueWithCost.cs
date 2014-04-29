﻿#region License
/**
 * Copyright (c) 2013-2014 Robert Rouhani <robert.rouhani@gmail.com> and other contributors (see CONTRIBUTORS file).
 * Licensed under the MIT License - https://raw.github.com/Robmaister/SharpNav/master/LICENSE
 */
#endregion

namespace SharpNav.Collections.Generic
{
	/// <summary>
	/// An interface that defines a class containing a cost associated with the instance.
	/// Used in <see cref="PriorityQueue{T}"/>
	/// </summary>
	public interface IValueWithCost
	{
		/// <summary>
		/// The cost of this instance.
		/// </summary>
		float Cost { get; }
	}
}
