using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@lzham_decompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_decompressor::init(void)")]
[CleanName("init")]
internal static partial class init_fucheg
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			init_position_slots.Invoke(&((lzham_lzham_decompressor*)@this)->m_lzBase, ((lzham_lzham_decompressor*)@this)->m_params.m_dict_size_log2);
			((lzham_lzham_decompressor*)@this)->m_state = 0;
			((lzham_lzham_decompressor*)@this)->m_step = 0;
			((lzham_lzham_decompressor*)@this)->m_block_step = 0;
			((lzham_lzham_decompressor*)@this)->m_block_index = 0;
			((lzham_lzham_decompressor*)@this)->m_initial_step = 0;
			((lzham_lzham_decompressor*)@this)->m_dst_ofs = 0;
			((lzham_lzham_decompressor*)@this)->m_dst_highwater_ofs = 0;
			((lzham_lzham_decompressor*)@this)->m_pIn_buf = null;
			((lzham_lzham_decompressor*)@this)->m_pIn_buf_size = null;
			((lzham_lzham_decompressor*)@this)->m_pOut_buf = null;
			((lzham_lzham_decompressor*)@this)->m_pOut_buf_size = null;
			((lzham_lzham_decompressor*)@this)->m_no_more_input_bytes_flag = 0;
			((lzham_lzham_decompressor*)@this)->m_status = 0;
			((lzham_lzham_decompressor*)@this)->m_pOrig_out_buf = null;
			((lzham_lzham_decompressor*)@this)->m_orig_out_buf_size = 0L;
			((lzham_lzham_decompressor*)@this)->m_decomp_adler32 = 1;
			((lzham_lzham_decompressor*)@this)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)@this)->m_z_last_status = 0;
			((lzham_lzham_decompressor*)@this)->m_z_first_call = 1;
			((lzham_lzham_decompressor*)@this)->m_z_has_flushed = 0;
			((lzham_lzham_decompressor*)@this)->m_z_cmf = 0;
			((lzham_lzham_decompressor*)@this)->m_z_flg = 0;
			((lzham_lzham_decompressor*)@this)->m_z_dict_adler32 = 0;
			((lzham_lzham_decompressor*)@this)->m_tmp = 0;
			((lzham_lzham_decompressor*)@this)->m_match_hist0 = 0;
			((lzham_lzham_decompressor*)@this)->m_match_hist1 = 0;
			((lzham_lzham_decompressor*)@this)->m_match_hist2 = 0;
			((lzham_lzham_decompressor*)@this)->m_match_hist3 = 0;
			((lzham_lzham_decompressor*)@this)->m_cur_state = 0;
			((lzham_lzham_decompressor*)@this)->m_start_block_dst_ofs = 0;
			((lzham_lzham_decompressor*)@this)->m_block_type = 0;
			((lzham_lzham_decompressor*)@this)->m_flush_num_bytes_remaining = 0L;
			((lzham_lzham_decompressor*)@this)->m_flush_n = 0L;
			((lzham_lzham_decompressor*)@this)->m_file_src_file_adler32 = 0;
			((lzham_lzham_decompressor*)@this)->m_rep_lit0 = 0;
			((lzham_lzham_decompressor*)@this)->m_match_len = 0;
			((lzham_lzham_decompressor*)@this)->m_match_slot = 0;
			((lzham_lzham_decompressor*)@this)->m_extra_bits = 0;
			((lzham_lzham_decompressor*)@this)->m_num_extra_bits = 0;
			((lzham_lzham_decompressor*)@this)->m_src_ofs = 0;
			((lzham_lzham_decompressor*)@this)->m_pCopy_src = null;
			((lzham_lzham_decompressor*)@this)->m_num_raw_bytes_remaining = 0;
			clear_sksy5s.Invoke(&((lzham_lzham_decompressor*)@this)->m_codec);
		}
	}
}
