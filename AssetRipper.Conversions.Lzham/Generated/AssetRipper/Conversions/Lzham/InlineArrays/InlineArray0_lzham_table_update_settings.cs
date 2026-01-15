using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

public partial struct InlineArray0_lzham_table_update_settings : IEquatable<InlineArray0_lzham_table_update_settings>, IEqualityOperators<InlineArray0_lzham_table_update_settings, InlineArray0_lzham_table_update_settings, bool>, IEnumerable, IInlineArray<InlineArray0_lzham_table_update_settings, lzham_table_update_settings>
{
	public static int Length => 0;

	public static bool operator ==(InlineArray0_lzham_table_update_settings x, InlineArray0_lzham_table_update_settings y)
	{
		return InlineArrayHelper.Equals<InlineArray0_lzham_table_update_settings, lzham_table_update_settings>(x, y);
	}

	public static bool operator !=(InlineArray0_lzham_table_update_settings x, InlineArray0_lzham_table_update_settings y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray0_lzham_table_update_settings other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray0_lzham_table_update_settings)
		{
			return Equals((InlineArray0_lzham_table_update_settings)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray0_lzham_table_update_settings, lzham_table_update_settings>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_table_update_settings>)this).GetEnumerator();
	}
}
