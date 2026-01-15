using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(57)]
public partial struct InlineArray57_SByte : IEquatable<InlineArray57_SByte>, IEqualityOperators<InlineArray57_SByte, InlineArray57_SByte, bool>, IEnumerable, IInlineArray<InlineArray57_SByte, sbyte>, IInlineArray<InlineArray57_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 57;

	public static bool operator ==(InlineArray57_SByte x, InlineArray57_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray57_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray57_SByte x, InlineArray57_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray57_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray57_SByte)
		{
			return Equals((InlineArray57_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray57_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
