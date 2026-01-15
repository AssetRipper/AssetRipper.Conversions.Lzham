using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 714240)]
[MangledName("struct.lzham::lzcompressor::parse_thread_state")]
[DemangledName("lzham::lzcompressor::parse_thread_state")]
public partial struct lzham_lzcompressor_parse_thread_state
{
	[FieldOffset(0)]
	public lzham_lzcompressor_raw_parse_thread_state field_0;

	[FieldOffset(714200)]
	public InlineArray40_SByte field_1;
}
