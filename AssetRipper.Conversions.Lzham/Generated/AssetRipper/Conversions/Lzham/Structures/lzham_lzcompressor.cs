using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 6444504)]
[MangledName("class.lzham::lzcompressor")]
[DemangledName("lzham::lzcompressor")]
public partial struct lzham_lzcompressor
{
	[FieldOffset(0)]
	public lzham_CLZBase field_0;

	[FieldOffset(16)]
	public lzham_lzcompressor_init_params field_1;

	[FieldOffset(72)]
	public lzham_comp_settings field_2;

	[FieldOffset(88)]
	public long field_3;

	[FieldOffset(96)]
	public int field_4;

	[FieldOffset(104)]
	public lzham_search_accelerator field_5;

	[FieldOffset(304)]
	public lzham_symbol_codec field_6;

	[FieldOffset(472)]
	public lzham_lzcompressor_coding_stats field_7;

	[FieldOffset(13776)]
	public lzham_vector field_8;

	[FieldOffset(13792)]
	public lzham_vector field_9;

	[FieldOffset(13808)]
	public int field_10;

	[FieldOffset(13812)]
	public int field_11;

	[FieldOffset(13816)]
	public int field_12;

	[FieldOffset(13820)]
	public sbyte field_13;

	[FieldOffset(13821)]
	public sbyte field_14;

	[FieldOffset(13824)]
	public lzham_lzcompressor_state field_15;

	[FieldOffset(15024)]
	public lzham_lzcompressor_state field_16;

	[FieldOffset(16224)]
	public int field_17;

	[FieldOffset(16232)]
	public InlineArray9_lzham_lzcompressor_parse_thread_state field_18;

	[FieldOffset(6444392)]
	public int field_19;

	[FieldOffset(6444396)]
	public InlineArray4_SByte field_20;

	[FieldOffset(6444400)]
	public InlineArray6_lzham_lzcompressor_block_history field_21;

	[FieldOffset(6444496)]
	public int field_22;

	[FieldOffset(6444500)]
	public int field_23;
}
