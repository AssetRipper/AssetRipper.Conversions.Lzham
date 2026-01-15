using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(35)]
public partial struct InlineArray35_Int32 : IEquatable<InlineArray35_Int32>, IEqualityOperators<InlineArray35_Int32, InlineArray35_Int32, bool>, IEnumerable, IInlineArray<InlineArray35_Int32, int>, IInlineArray<InlineArray35_Int32, uint>
{
	private int __element0;

	public static int Length => 35;

	public static bool operator ==(InlineArray35_Int32 x, InlineArray35_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray35_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray35_Int32 x, InlineArray35_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray35_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray35_Int32)
		{
			return Equals((InlineArray35_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray35_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
