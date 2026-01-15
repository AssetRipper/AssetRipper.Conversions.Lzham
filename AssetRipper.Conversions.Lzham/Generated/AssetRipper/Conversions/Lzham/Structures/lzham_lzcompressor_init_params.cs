using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 56)]
[MangledName("struct.lzham::lzcompressor::init_params")]
[DemangledName("lzham::lzcompressor::init_params")]
public partial struct lzham_lzcompressor_init_params
{
	[FieldOffset(0)]
	public unsafe void* m_pTask_pool;

	[FieldOffset(8)]
	public int m_max_helper_threads;

	[FieldOffset(12)]
	public int m_compression_level;

	[FieldOffset(16)]
	public int m_dict_size_log2;

	[FieldOffset(20)]
	public int m_block_size;

	[FieldOffset(24)]
	public int m_lzham_compress_flags;

	[FieldOffset(32)]
	public unsafe void* m_pSeed_bytes;

	[FieldOffset(40)]
	public int m_num_seed_bytes;

	[FieldOffset(44)]
	public int m_table_max_update_interval;

	[FieldOffset(48)]
	public int m_table_update_interval_slow_rate;
}
