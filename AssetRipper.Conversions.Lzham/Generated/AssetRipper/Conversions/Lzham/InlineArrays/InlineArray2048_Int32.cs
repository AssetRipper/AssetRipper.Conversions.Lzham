using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(2048)]
public partial struct InlineArray2048_Int32 : IEquatable<InlineArray2048_Int32>, IEqualityOperators<InlineArray2048_Int32, InlineArray2048_Int32, bool>, IEnumerable, IInlineArray<InlineArray2048_Int32, int>, IInlineArray<InlineArray2048_Int32, uint>
{
	private int __element0;

	public static int Length => 2048;

	public static bool operator ==(InlineArray2048_Int32 x, InlineArray2048_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray2048_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray2048_Int32 x, InlineArray2048_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2048_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2048_Int32)
		{
			return Equals((InlineArray2048_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2048_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
