using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("struct.lzham_compress_params")]
public partial struct lzham_compress_params
{
	[FieldOffset(0)]
	public int m_struct_size;

	[FieldOffset(4)]
	public int m_dict_size_log2;

	[FieldOffset(8)]
	public int m_level;

	[FieldOffset(12)]
	public int m_table_update_rate;

	[FieldOffset(16)]
	public int m_max_helper_threads;

	[FieldOffset(20)]
	public int m_compress_flags;

	[FieldOffset(24)]
	public int m_num_seed_bytes;

	[FieldOffset(32)]
	public unsafe void* m_pSeed_bytes;

	[FieldOffset(40)]
	public int m_table_max_update_interval;

	[FieldOffset(44)]
	public int m_table_update_interval_slow_rate;
}
