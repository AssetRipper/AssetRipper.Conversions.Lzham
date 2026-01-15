using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 104)]
[MangledName("class.lzham::raw_quasi_adaptive_huffman_data_model")]
[DemangledName("lzham::raw_quasi_adaptive_huffman_data_model")]
public partial struct lzham_raw_quasi_adaptive_huffman_data_model
{
	[FieldOffset(0)]
	public lzham_vector m_initial_sym_freq;

	[FieldOffset(16)]
	public lzham_vector m_sym_freq;

	[FieldOffset(32)]
	public lzham_vector m_codes;

	[FieldOffset(48)]
	public lzham_vector m_code_sizes;

	[FieldOffset(64)]
	public unsafe void* m_pDecode_tables;

	[FieldOffset(72)]
	public int m_total_syms;

	[FieldOffset(76)]
	public int m_max_cycle;

	[FieldOffset(80)]
	public int m_update_cycle;

	[FieldOffset(84)]
	public int m_symbols_until_update;

	[FieldOffset(88)]
	public int m_total_count;

	[FieldOffset(92)]
	public sbyte m_decoder_table_bits;

	[FieldOffset(94)]
	public short m_max_update_interval;

	[FieldOffset(96)]
	public short m_adapt_rate;

	[FieldOffset(98)]
	public sbyte m_encoding;
}
