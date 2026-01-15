using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("struct.lzham::CLZBase")]
[DemangledName("lzham::CLZBase")]
public partial struct lzham_CLZBase
{
	[FieldOffset(0)]
	public lzham_CLZDecompBase field_0;
}
