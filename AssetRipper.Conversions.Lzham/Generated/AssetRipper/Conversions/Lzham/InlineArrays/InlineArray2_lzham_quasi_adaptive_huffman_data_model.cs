using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_lzham_quasi_adaptive_huffman_data_model : IEquatable<InlineArray2_lzham_quasi_adaptive_huffman_data_model>, IEqualityOperators<InlineArray2_lzham_quasi_adaptive_huffman_data_model, InlineArray2_lzham_quasi_adaptive_huffman_data_model, bool>, IEnumerable, IInlineArray<InlineArray2_lzham_quasi_adaptive_huffman_data_model, lzham_quasi_adaptive_huffman_data_model>
{
	private lzham_quasi_adaptive_huffman_data_model __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_lzham_quasi_adaptive_huffman_data_model x, InlineArray2_lzham_quasi_adaptive_huffman_data_model y)
	{
		return InlineArrayHelper.Equals<InlineArray2_lzham_quasi_adaptive_huffman_data_model, lzham_quasi_adaptive_huffman_data_model>(x, y);
	}

	public static bool operator !=(InlineArray2_lzham_quasi_adaptive_huffman_data_model x, InlineArray2_lzham_quasi_adaptive_huffman_data_model y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_lzham_quasi_adaptive_huffman_data_model other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_lzham_quasi_adaptive_huffman_data_model)
		{
			return Equals((InlineArray2_lzham_quasi_adaptive_huffman_data_model)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_lzham_quasi_adaptive_huffman_data_model, lzham_quasi_adaptive_huffman_data_model>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_quasi_adaptive_huffman_data_model>)this).GetEnumerator();
	}
}
