using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(1024)]
public partial struct InlineArray1024_Int32 : IEquatable<InlineArray1024_Int32>, IEqualityOperators<InlineArray1024_Int32, InlineArray1024_Int32, bool>, IEnumerable, IInlineArray<InlineArray1024_Int32, int>, IInlineArray<InlineArray1024_Int32, uint>
{
	private int __element0;

	public static int Length => 1024;

	public static bool operator ==(InlineArray1024_Int32 x, InlineArray1024_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray1024_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray1024_Int32 x, InlineArray1024_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1024_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1024_Int32)
		{
			return Equals((InlineArray1024_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1024_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
