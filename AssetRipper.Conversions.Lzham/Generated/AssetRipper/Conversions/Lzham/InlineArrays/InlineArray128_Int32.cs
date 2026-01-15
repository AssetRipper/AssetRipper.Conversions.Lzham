using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Int32 : IEquatable<InlineArray128_Int32>, IEqualityOperators<InlineArray128_Int32, InlineArray128_Int32, bool>, IEnumerable, IInlineArray<InlineArray128_Int32, int>, IInlineArray<InlineArray128_Int32, uint>
{
	private int __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Int32 x, InlineArray128_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray128_Int32 x, InlineArray128_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray128_Int32)
		{
			return Equals((InlineArray128_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
