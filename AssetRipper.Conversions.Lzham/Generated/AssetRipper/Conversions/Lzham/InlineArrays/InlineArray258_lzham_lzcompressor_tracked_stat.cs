using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(258)]
public partial struct InlineArray258_lzham_lzcompressor_tracked_stat : IEquatable<InlineArray258_lzham_lzcompressor_tracked_stat>, IEqualityOperators<InlineArray258_lzham_lzcompressor_tracked_stat, InlineArray258_lzham_lzcompressor_tracked_stat, bool>, IEnumerable, IInlineArray<InlineArray258_lzham_lzcompressor_tracked_stat, lzham_lzcompressor_tracked_stat>
{
	private lzham_lzcompressor_tracked_stat __element0;

	public static int Length => 258;

	public static bool operator ==(InlineArray258_lzham_lzcompressor_tracked_stat x, InlineArray258_lzham_lzcompressor_tracked_stat y)
	{
		return InlineArrayHelper.Equals<InlineArray258_lzham_lzcompressor_tracked_stat, lzham_lzcompressor_tracked_stat>(x, y);
	}

	public static bool operator !=(InlineArray258_lzham_lzcompressor_tracked_stat x, InlineArray258_lzham_lzcompressor_tracked_stat y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray258_lzham_lzcompressor_tracked_stat other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray258_lzham_lzcompressor_tracked_stat)
		{
			return Equals((InlineArray258_lzham_lzcompressor_tracked_stat)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray258_lzham_lzcompressor_tracked_stat, lzham_lzcompressor_tracked_stat>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_lzcompressor_tracked_stat>)this).GetEnumerator();
	}
}
