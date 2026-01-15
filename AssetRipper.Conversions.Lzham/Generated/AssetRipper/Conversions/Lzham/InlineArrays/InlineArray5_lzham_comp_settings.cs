using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray5_lzham_comp_settings : IEquatable<InlineArray5_lzham_comp_settings>, IEqualityOperators<InlineArray5_lzham_comp_settings, InlineArray5_lzham_comp_settings, bool>, IEnumerable, IInlineArray<InlineArray5_lzham_comp_settings, lzham_comp_settings>
{
	private lzham_comp_settings __element0;

	public static int Length => 5;

	public static bool operator ==(InlineArray5_lzham_comp_settings x, InlineArray5_lzham_comp_settings y)
	{
		return InlineArrayHelper.Equals<InlineArray5_lzham_comp_settings, lzham_comp_settings>(x, y);
	}

	public static bool operator !=(InlineArray5_lzham_comp_settings x, InlineArray5_lzham_comp_settings y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray5_lzham_comp_settings other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray5_lzham_comp_settings)
		{
			return Equals((InlineArray5_lzham_comp_settings)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray5_lzham_comp_settings, lzham_comp_settings>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_comp_settings>)this).GetEnumerator();
	}
}
