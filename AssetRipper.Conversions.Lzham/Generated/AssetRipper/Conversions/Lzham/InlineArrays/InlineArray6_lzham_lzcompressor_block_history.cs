using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_lzham_lzcompressor_block_history : IEquatable<InlineArray6_lzham_lzcompressor_block_history>, IEqualityOperators<InlineArray6_lzham_lzcompressor_block_history, InlineArray6_lzham_lzcompressor_block_history, bool>, IEnumerable, IInlineArray<InlineArray6_lzham_lzcompressor_block_history, lzham_lzcompressor_block_history>
{
	private lzham_lzcompressor_block_history __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_lzham_lzcompressor_block_history x, InlineArray6_lzham_lzcompressor_block_history y)
	{
		return InlineArrayHelper.Equals<InlineArray6_lzham_lzcompressor_block_history, lzham_lzcompressor_block_history>(x, y);
	}

	public static bool operator !=(InlineArray6_lzham_lzcompressor_block_history x, InlineArray6_lzham_lzcompressor_block_history y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_lzham_lzcompressor_block_history other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray6_lzham_lzcompressor_block_history)
		{
			return Equals((InlineArray6_lzham_lzcompressor_block_history)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_lzham_lzcompressor_block_history, lzham_lzcompressor_block_history>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_lzcompressor_block_history>)this).GetEnumerator();
	}
}
