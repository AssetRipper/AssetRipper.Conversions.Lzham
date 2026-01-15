using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.lzham::table_update_settings")]
[DemangledName("lzham::table_update_settings")]
public partial struct lzham_table_update_settings
{
	[FieldOffset(0)]
	public short m_max_update_interval;

	[FieldOffset(2)]
	public short m_slow_rate;
}
