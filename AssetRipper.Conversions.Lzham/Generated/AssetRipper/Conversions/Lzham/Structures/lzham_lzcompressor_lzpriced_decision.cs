using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.lzham::lzcompressor::lzpriced_decision")]
[DemangledName("lzham::lzcompressor::lzpriced_decision")]
public partial struct lzham_lzcompressor_lzpriced_decision
{
	[FieldOffset(0)]
	public lzham_CLZDecompBase field_0;

	[FieldOffset(16)]
	public long field_1;
}
