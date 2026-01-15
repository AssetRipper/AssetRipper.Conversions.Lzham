using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 714200)]
[MangledName("struct.lzham::lzcompressor::raw_parse_thread_state")]
[DemangledName("lzham::lzcompressor::raw_parse_thread_state")]
public partial struct lzham_lzcompressor_raw_parse_thread_state
{
	[FieldOffset(0)]
	public int m_start_ofs;

	[FieldOffset(4)]
	public int m_bytes_to_match;

	[FieldOffset(8)]
	public lzham_lzcompressor_state m_initial_state;

	[FieldOffset(1208)]
	public InlineArray3073_lzham_lzcompressor_node m_nodes;

	[FieldOffset(714144)]
	public lzham_vector m_best_decisions;

	[FieldOffset(714160)]
	public sbyte m_emit_decisions_backwards;

	[FieldOffset(714168)]
	public lzham_vector m_temp_decisions;

	[FieldOffset(714184)]
	public int m_max_greedy_decisions;

	[FieldOffset(714188)]
	public int m_greedy_parse_total_bytes_coded;

	[FieldOffset(714192)]
	public sbyte m_greedy_parse_gave_up;

	[FieldOffset(714193)]
	public sbyte m_issue_reset_state_partial;

	[FieldOffset(714194)]
	public sbyte m_failed;
}
