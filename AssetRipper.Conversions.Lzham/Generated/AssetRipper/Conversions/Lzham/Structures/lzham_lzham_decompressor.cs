using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 1656)]
[MangledName("struct.lzham::lzham_decompressor")]
[DemangledName("lzham::lzham_decompressor")]
public partial struct lzham_lzham_decompressor
{
	[FieldOffset(0)]
	public int m_state;

	[FieldOffset(4)]
	public lzham_CLZDecompBase m_lzBase;

	[FieldOffset(16)]
	public lzham_symbol_codec m_codec;

	[FieldOffset(184)]
	public int m_raw_decomp_buf_size;

	[FieldOffset(192)]
	public unsafe void* m_pRaw_decomp_buf;

	[FieldOffset(200)]
	public unsafe void* m_pDecomp_buf;

	[FieldOffset(208)]
	public int m_decomp_adler32;

	[FieldOffset(216)]
	public unsafe void* m_pIn_buf;

	[FieldOffset(224)]
	public unsafe void* m_pIn_buf_size;

	[FieldOffset(232)]
	public unsafe void* m_pOut_buf;

	[FieldOffset(240)]
	public unsafe void* m_pOut_buf_size;

	[FieldOffset(248)]
	public sbyte m_no_more_input_bytes_flag;

	[FieldOffset(256)]
	public unsafe void* m_pOrig_out_buf;

	[FieldOffset(264)]
	public long m_orig_out_buf_size;

	[FieldOffset(272)]
	public lzham_decompress_params m_params;

	[FieldOffset(312)]
	public int m_status;

	[FieldOffset(320)]
	public lzham_quasi_adaptive_huffman_data_model m_lit_table;

	[FieldOffset(448)]
	public lzham_quasi_adaptive_huffman_data_model m_delta_lit_table;

	[FieldOffset(576)]
	public lzham_quasi_adaptive_huffman_data_model m_main_table;

	[FieldOffset(704)]
	public InlineArray2_lzham_quasi_adaptive_huffman_data_model m_rep_len_table;

	[FieldOffset(960)]
	public InlineArray2_lzham_quasi_adaptive_huffman_data_model m_large_len_table;

	[FieldOffset(1216)]
	public lzham_quasi_adaptive_huffman_data_model m_dist_lsb_table;

	[FieldOffset(1344)]
	public InlineArray12_lzham_adaptive_bit_model m_is_match_model;

	[FieldOffset(1368)]
	public InlineArray12_lzham_adaptive_bit_model m_is_rep_model;

	[FieldOffset(1392)]
	public InlineArray12_lzham_adaptive_bit_model m_is_rep0_model;

	[FieldOffset(1416)]
	public InlineArray12_lzham_adaptive_bit_model m_is_rep0_single_byte_model;

	[FieldOffset(1440)]
	public InlineArray12_lzham_adaptive_bit_model m_is_rep1_model;

	[FieldOffset(1464)]
	public InlineArray12_lzham_adaptive_bit_model m_is_rep2_model;

	[FieldOffset(1488)]
	public int m_dst_ofs;

	[FieldOffset(1492)]
	public int m_dst_highwater_ofs;

	[FieldOffset(1496)]
	public int m_step;

	[FieldOffset(1500)]
	public int m_block_step;

	[FieldOffset(1504)]
	public int m_initial_step;

	[FieldOffset(1508)]
	public int m_block_index;

	[FieldOffset(1512)]
	public int m_match_hist0;

	[FieldOffset(1516)]
	public int m_match_hist1;

	[FieldOffset(1520)]
	public int m_match_hist2;

	[FieldOffset(1524)]
	public int m_match_hist3;

	[FieldOffset(1528)]
	public int m_cur_state;

	[FieldOffset(1532)]
	public int m_start_block_dst_ofs;

	[FieldOffset(1536)]
	public int m_block_type;

	[FieldOffset(1544)]
	public unsafe void* m_pFlush_src;

	[FieldOffset(1552)]
	public long m_flush_num_bytes_remaining;

	[FieldOffset(1560)]
	public long m_flush_n;

	[FieldOffset(1568)]
	public int m_seed_bytes_to_ignore_when_flushing;

	[FieldOffset(1572)]
	public int m_file_src_file_adler32;

	[FieldOffset(1576)]
	public int m_rep_lit0;

	[FieldOffset(1580)]
	public int m_match_len;

	[FieldOffset(1584)]
	public int m_match_slot;

	[FieldOffset(1588)]
	public int m_extra_bits;

	[FieldOffset(1592)]
	public int m_num_extra_bits;

	[FieldOffset(1596)]
	public int m_src_ofs;

	[FieldOffset(1600)]
	public unsafe void* m_pCopy_src;

	[FieldOffset(1608)]
	public int m_num_raw_bytes_remaining;

	[FieldOffset(1612)]
	public int m_debug_is_match;

	[FieldOffset(1616)]
	public int m_debug_match_len;

	[FieldOffset(1620)]
	public int m_debug_match_dist;

	[FieldOffset(1624)]
	public int m_debug_lit;

	[FieldOffset(1628)]
	public int m_z_last_status;

	[FieldOffset(1632)]
	public int m_z_first_call;

	[FieldOffset(1636)]
	public int m_z_has_flushed;

	[FieldOffset(1640)]
	public int m_z_cmf;

	[FieldOffset(1644)]
	public int m_z_flg;

	[FieldOffset(1648)]
	public int m_z_dict_adler32;

	[FieldOffset(1652)]
	public int m_tmp;
}
