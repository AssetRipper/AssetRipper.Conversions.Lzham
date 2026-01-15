using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_lzham_lzcompressor_node_state : IEquatable<InlineArray4_lzham_lzcompressor_node_state>, IEqualityOperators<InlineArray4_lzham_lzcompressor_node_state, InlineArray4_lzham_lzcompressor_node_state, bool>, IEnumerable, IInlineArray<InlineArray4_lzham_lzcompressor_node_state, lzham_lzcompressor_node_state>
{
	private lzham_lzcompressor_node_state __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_lzham_lzcompressor_node_state x, InlineArray4_lzham_lzcompressor_node_state y)
	{
		return InlineArrayHelper.Equals<InlineArray4_lzham_lzcompressor_node_state, lzham_lzcompressor_node_state>(x, y);
	}

	public static bool operator !=(InlineArray4_lzham_lzcompressor_node_state x, InlineArray4_lzham_lzcompressor_node_state y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_lzham_lzcompressor_node_state other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray4_lzham_lzcompressor_node_state)
		{
			return Equals((InlineArray4_lzham_lzcompressor_node_state)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_lzham_lzcompressor_node_state, lzham_lzcompressor_node_state>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_lzcompressor_node_state>)this).GetEnumerator();
	}
}
