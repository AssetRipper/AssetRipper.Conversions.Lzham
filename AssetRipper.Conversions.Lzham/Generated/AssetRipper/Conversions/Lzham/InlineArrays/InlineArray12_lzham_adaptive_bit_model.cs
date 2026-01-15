using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_lzham_adaptive_bit_model : IEquatable<InlineArray12_lzham_adaptive_bit_model>, IEqualityOperators<InlineArray12_lzham_adaptive_bit_model, InlineArray12_lzham_adaptive_bit_model, bool>, IEnumerable, IInlineArray<InlineArray12_lzham_adaptive_bit_model, lzham_adaptive_bit_model>
{
	private lzham_adaptive_bit_model __element0;

	public static int Length => 12;

	public static bool operator ==(InlineArray12_lzham_adaptive_bit_model x, InlineArray12_lzham_adaptive_bit_model y)
	{
		return InlineArrayHelper.Equals<InlineArray12_lzham_adaptive_bit_model, lzham_adaptive_bit_model>(x, y);
	}

	public static bool operator !=(InlineArray12_lzham_adaptive_bit_model x, InlineArray12_lzham_adaptive_bit_model y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_lzham_adaptive_bit_model other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray12_lzham_adaptive_bit_model)
		{
			return Equals((InlineArray12_lzham_adaptive_bit_model)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_lzham_adaptive_bit_model, lzham_adaptive_bit_model>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_adaptive_bit_model>)this).GetEnumerator();
	}
}
