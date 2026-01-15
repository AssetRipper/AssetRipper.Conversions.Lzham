using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(2049)]
public partial struct InlineArray2049_lzham_sym_freq : IEquatable<InlineArray2049_lzham_sym_freq>, IEqualityOperators<InlineArray2049_lzham_sym_freq, InlineArray2049_lzham_sym_freq, bool>, IEnumerable, IInlineArray<InlineArray2049_lzham_sym_freq, lzham_sym_freq>
{
	private lzham_sym_freq __element0;

	public static int Length => 2049;

	public static bool operator ==(InlineArray2049_lzham_sym_freq x, InlineArray2049_lzham_sym_freq y)
	{
		return InlineArrayHelper.Equals<InlineArray2049_lzham_sym_freq, lzham_sym_freq>(x, y);
	}

	public static bool operator !=(InlineArray2049_lzham_sym_freq x, InlineArray2049_lzham_sym_freq y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2049_lzham_sym_freq other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2049_lzham_sym_freq)
		{
			return Equals((InlineArray2049_lzham_sym_freq)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2049_lzham_sym_freq, lzham_sym_freq>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_sym_freq>)this).GetEnumerator();
	}
}
