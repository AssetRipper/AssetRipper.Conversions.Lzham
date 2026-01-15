using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 168)]
[MangledName("class.lzham::symbol_codec")]
[DemangledName("lzham::symbol_codec")]
public partial struct lzham_symbol_codec
{
	[FieldOffset(0)]
	public unsafe void* m_pDecode_buf;

	[FieldOffset(8)]
	public unsafe void* m_pDecode_buf_next;

	[FieldOffset(16)]
	public unsafe void* m_pDecode_buf_end;

	[FieldOffset(24)]
	public long m_decode_buf_size;

	[FieldOffset(32)]
	public sbyte m_decode_buf_eof;

	[FieldOffset(40)]
	public unsafe void* m_pDecode_need_bytes_func;

	[FieldOffset(48)]
	public unsafe void* m_pDecode_private_data;

	[FieldOffset(56)]
	public long m_bit_buf;

	[FieldOffset(64)]
	public int m_bit_count;

	[FieldOffset(68)]
	public int m_total_model_updates;

	[FieldOffset(72)]
	public lzham_vector m_output_buf;

	[FieldOffset(88)]
	public lzham_vector m_arith_output_buf;

	[FieldOffset(104)]
	public lzham_vector m_output_syms;

	[FieldOffset(120)]
	public int m_total_bits_written;

	[FieldOffset(124)]
	public int m_arith_base;

	[FieldOffset(128)]
	public int m_arith_value;

	[FieldOffset(132)]
	public int m_arith_length;

	[FieldOffset(136)]
	public int m_arith_total_bits;

	[FieldOffset(144)]
	public unsafe void* m_pSaved_huff_model;

	[FieldOffset(152)]
	public unsafe void* m_pSaved_model;

	[FieldOffset(160)]
	public int m_saved_node_index;

	[FieldOffset(164)]
	public int m_mode;
}
