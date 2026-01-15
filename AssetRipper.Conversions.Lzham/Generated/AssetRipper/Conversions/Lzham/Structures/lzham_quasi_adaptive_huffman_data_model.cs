using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("struct.lzham::quasi_adaptive_huffman_data_model")]
[DemangledName("lzham::quasi_adaptive_huffman_data_model")]
public partial struct lzham_quasi_adaptive_huffman_data_model
{
	[FieldOffset(0)]
	public lzham_raw_quasi_adaptive_huffman_data_model field_0;

	[FieldOffset(104)]
	public InlineArray24_SByte field_1;
}
