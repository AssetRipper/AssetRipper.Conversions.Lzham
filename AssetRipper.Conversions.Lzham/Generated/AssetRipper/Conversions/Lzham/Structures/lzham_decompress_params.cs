using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("struct.lzham_decompress_params")]
public partial struct lzham_decompress_params
{
	[FieldOffset(0)]
	public int m_struct_size;

	[FieldOffset(4)]
	public int m_dict_size_log2;

	[FieldOffset(8)]
	public int m_table_update_rate;

	[FieldOffset(12)]
	public int m_decompress_flags;

	[FieldOffset(16)]
	public int m_num_seed_bytes;

	[FieldOffset(24)]
	public unsafe void* m_pSeed_bytes;

	[FieldOffset(32)]
	public int m_table_max_update_interval;

	[FieldOffset(36)]
	public int m_table_update_interval_slow_rate;
}
