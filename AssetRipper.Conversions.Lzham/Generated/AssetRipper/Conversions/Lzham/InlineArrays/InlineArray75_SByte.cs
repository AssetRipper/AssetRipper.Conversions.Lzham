using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(75)]
public partial struct InlineArray75_SByte : IEquatable<InlineArray75_SByte>, IEqualityOperators<InlineArray75_SByte, InlineArray75_SByte, bool>, IEnumerable, IInlineArray<InlineArray75_SByte, sbyte>, IInlineArray<InlineArray75_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 75;

	public static bool operator ==(InlineArray75_SByte x, InlineArray75_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray75_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray75_SByte x, InlineArray75_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray75_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray75_SByte)
		{
			return Equals((InlineArray75_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray75_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
