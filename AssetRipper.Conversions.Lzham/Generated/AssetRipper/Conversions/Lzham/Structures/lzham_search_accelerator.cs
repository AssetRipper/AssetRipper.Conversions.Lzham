using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 200)]
[MangledName("class.lzham::search_accelerator")]
[DemangledName("lzham::search_accelerator")]
public partial struct lzham_search_accelerator
{
	[FieldOffset(0)]
	public unsafe void* m_pLZBase;

	[FieldOffset(8)]
	public unsafe void* m_pTask_pool;

	[FieldOffset(16)]
	public int m_max_helper_threads;

	[FieldOffset(20)]
	public int m_max_dict_size;

	[FieldOffset(24)]
	public int m_max_dict_size_mask;

	[FieldOffset(28)]
	public int m_lookahead_pos;

	[FieldOffset(32)]
	public int m_lookahead_size;

	[FieldOffset(36)]
	public int m_cur_dict_size;

	[FieldOffset(40)]
	public lzham_vector m_dict;

	[FieldOffset(56)]
	public lzham_vector m_hash;

	[FieldOffset(72)]
	public lzham_vector m_nodes;

	[FieldOffset(88)]
	public lzham_vector m_matches;

	[FieldOffset(104)]
	public lzham_vector m_match_refs;

	[FieldOffset(120)]
	public lzham_vector m_hash_thread_index;

	[FieldOffset(136)]
	public lzham_vector m_digram_hash;

	[FieldOffset(152)]
	public lzham_vector m_digram_next;

	[FieldOffset(168)]
	public int m_fill_lookahead_pos;

	[FieldOffset(172)]
	public int m_fill_lookahead_size;

	[FieldOffset(176)]
	public int m_fill_dict_size;

	[FieldOffset(180)]
	public int m_max_probes;

	[FieldOffset(184)]
	public int m_max_matches;

	[FieldOffset(188)]
	public sbyte m_all_matches;

	[FieldOffset(192)]
	public int m_next_match_ref;

	[FieldOffset(196)]
	public int m_num_completed_helper_threads;
}
