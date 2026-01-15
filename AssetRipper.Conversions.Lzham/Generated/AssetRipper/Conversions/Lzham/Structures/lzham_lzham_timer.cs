using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.lzham::lzham_timer")]
[DemangledName("lzham::lzham_timer")]
public partial struct lzham_lzham_timer
{
	[FieldOffset(0)]
	public long field_0;

	[FieldOffset(8)]
	public long field_1;

	[FieldOffset(16)]
	public sbyte field_2;
}
