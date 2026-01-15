using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(3073)]
public partial struct InlineArray3073_lzham_lzcompressor_node : IEquatable<InlineArray3073_lzham_lzcompressor_node>, IEqualityOperators<InlineArray3073_lzham_lzcompressor_node, InlineArray3073_lzham_lzcompressor_node, bool>, IEnumerable, IInlineArray<InlineArray3073_lzham_lzcompressor_node, lzham_lzcompressor_node>
{
	private lzham_lzcompressor_node __element0;

	public static int Length => 3073;

	public static bool operator ==(InlineArray3073_lzham_lzcompressor_node x, InlineArray3073_lzham_lzcompressor_node y)
	{
		return InlineArrayHelper.Equals<InlineArray3073_lzham_lzcompressor_node, lzham_lzcompressor_node>(x, y);
	}

	public static bool operator !=(InlineArray3073_lzham_lzcompressor_node x, InlineArray3073_lzham_lzcompressor_node y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3073_lzham_lzcompressor_node other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3073_lzham_lzcompressor_node)
		{
			return Equals((InlineArray3073_lzham_lzcompressor_node)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3073_lzham_lzcompressor_node, lzham_lzcompressor_node>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_lzcompressor_node>)this).GetEnumerator();
	}
}
