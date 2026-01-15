using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(117)]
public partial struct InlineArray117_SByte : IEquatable<InlineArray117_SByte>, IEqualityOperators<InlineArray117_SByte, InlineArray117_SByte, bool>, IEnumerable, IInlineArray<InlineArray117_SByte, sbyte>, IInlineArray<InlineArray117_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 117;

	public static bool operator ==(InlineArray117_SByte x, InlineArray117_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray117_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray117_SByte x, InlineArray117_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray117_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray117_SByte)
		{
			return Equals((InlineArray117_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray117_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
