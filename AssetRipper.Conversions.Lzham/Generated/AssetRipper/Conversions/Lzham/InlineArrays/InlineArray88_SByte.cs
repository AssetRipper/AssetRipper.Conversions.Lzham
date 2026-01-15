using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(88)]
public partial struct InlineArray88_SByte : IEquatable<InlineArray88_SByte>, IEqualityOperators<InlineArray88_SByte, InlineArray88_SByte, bool>, IEnumerable, IInlineArray<InlineArray88_SByte, sbyte>, IInlineArray<InlineArray88_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 88;

	public static bool operator ==(InlineArray88_SByte x, InlineArray88_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray88_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray88_SByte x, InlineArray88_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray88_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray88_SByte)
		{
			return Equals((InlineArray88_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray88_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
