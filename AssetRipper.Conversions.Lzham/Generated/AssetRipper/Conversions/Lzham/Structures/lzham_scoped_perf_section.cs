using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 1)]
[MangledName("class.lzham::scoped_perf_section")]
[DemangledName("lzham::scoped_perf_section")]
public partial struct lzham_scoped_perf_section
{
	[FieldOffset(0)]
	public sbyte field_0;
}
