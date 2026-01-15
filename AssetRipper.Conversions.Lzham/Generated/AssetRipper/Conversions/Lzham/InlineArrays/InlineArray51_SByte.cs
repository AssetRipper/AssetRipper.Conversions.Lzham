using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(51)]
public partial struct InlineArray51_SByte : IEquatable<InlineArray51_SByte>, IEqualityOperators<InlineArray51_SByte, InlineArray51_SByte, bool>, IEnumerable, IInlineArray<InlineArray51_SByte, sbyte>, IInlineArray<InlineArray51_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 51;

	public static bool operator ==(InlineArray51_SByte x, InlineArray51_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray51_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray51_SByte x, InlineArray51_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray51_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray51_SByte)
		{
			return Equals((InlineArray51_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray51_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
