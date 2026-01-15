using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(81)]
public partial struct InlineArray81_SByte : IEquatable<InlineArray81_SByte>, IEqualityOperators<InlineArray81_SByte, InlineArray81_SByte, bool>, IEnumerable, IInlineArray<InlineArray81_SByte, sbyte>, IInlineArray<InlineArray81_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 81;

	public static bool operator ==(InlineArray81_SByte x, InlineArray81_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray81_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray81_SByte x, InlineArray81_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray81_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray81_SByte)
		{
			return Equals((InlineArray81_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray81_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
