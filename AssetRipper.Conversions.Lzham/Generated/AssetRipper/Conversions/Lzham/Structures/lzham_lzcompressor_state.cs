using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 1200)]
[MangledName("class.lzham::lzcompressor::state")]
[DemangledName("lzham::lzcompressor::state")]
public partial struct lzham_lzcompressor_state
{
	[FieldOffset(0)]
	public lzham_lzcompressor_state_base field_0;

	[FieldOffset(24)]
	public int field_1;

	[FieldOffset(28)]
	public InlineArray12_lzham_adaptive_bit_model field_2;

	[FieldOffset(52)]
	public InlineArray12_lzham_adaptive_bit_model field_3;

	[FieldOffset(76)]
	public InlineArray12_lzham_adaptive_bit_model field_4;

	[FieldOffset(100)]
	public InlineArray12_lzham_adaptive_bit_model field_5;

	[FieldOffset(124)]
	public InlineArray12_lzham_adaptive_bit_model field_6;

	[FieldOffset(148)]
	public InlineArray12_lzham_adaptive_bit_model field_7;

	[FieldOffset(176)]
	public lzham_quasi_adaptive_huffman_data_model field_8;

	[FieldOffset(304)]
	public lzham_quasi_adaptive_huffman_data_model field_9;

	[FieldOffset(432)]
	public lzham_quasi_adaptive_huffman_data_model field_10;

	[FieldOffset(560)]
	public InlineArray2_lzham_quasi_adaptive_huffman_data_model field_11;

	[FieldOffset(816)]
	public InlineArray2_lzham_quasi_adaptive_huffman_data_model field_12;

	[FieldOffset(1072)]
	public lzham_quasi_adaptive_huffman_data_model field_13;
}
