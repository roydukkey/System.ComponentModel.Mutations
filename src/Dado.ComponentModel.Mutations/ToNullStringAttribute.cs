// Copyright (c) roydukkey. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See the LICENSE file in the project root for more information.

using System;

namespace Dado.ComponentModel.DataMutations
{
	/// <summary>
	///		Used to mutate the a string to <c>null</c> when its value is empty or whitespace.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class ToNullStringAttribute : MutationAttribute
	{
		#region Properties

		/// <summary>
		///		Gets or sets a value indicating the priority that determines the order in which <see cref="MutationAttribute" />s are evaluated. Defaults to <c>30</c>.
		/// </summary>
		public override int Priority { get; set; } = 30;

		#endregion Properties

		#region Protected Methods

		/// <summary>
		///		Implements the mutation logic for this <see cref="ToNullStringAttribute" />.
		/// </summary>
		/// <param name="value">The value to mutate.</param>
		/// <param name="context">Describes the <paramref name="value" /> being mutated and provides services and context for mutation.</param>
		/// <returns><c>null</c> when the <paramref name="value" /> is empty or whitespace, otherwise the specified <paramref name="value" />.</returns>
		protected override object MutateValue(object value, IMutationContext context)
			=> value is string valueAsString && String.IsNullOrWhiteSpace(valueAsString)
				? null
				: value;

		#endregion Protected Methods
	}
}
