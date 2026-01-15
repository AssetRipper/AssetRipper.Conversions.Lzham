using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(65)]
public partial struct InlineArray65_SByte : IEquatable<InlineArray65_SByte>, IEqualityOperators<InlineArray65_SByte, InlineArray65_SByte, bool>, IEnumerable, IInlineArray<InlineArray65_SByte, sbyte>, IInlineArray<InlineArray65_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 65;

	public static bool operator ==(InlineArray65_SByte x, InlineArray65_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray65_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray65_SByte x, InlineArray65_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray65_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray65_SByte)
		{
			return Equals((InlineArray65_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray65_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
