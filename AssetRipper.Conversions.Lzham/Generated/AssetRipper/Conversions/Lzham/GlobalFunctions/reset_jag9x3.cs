using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::reset(void)")]
[CleanName("reset")]
internal static partial class reset_jag9x3
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_pDecode_buf = null;
			((lzham_symbol_codec*)@this)->m_pDecode_buf_next = null;
			((lzham_symbol_codec*)@this)->m_pDecode_buf_end = null;
			((lzham_symbol_codec*)@this)->m_decode_buf_size = 0L;
			((lzham_symbol_codec*)@this)->m_bit_buf = 0L;
			((lzham_symbol_codec*)@this)->m_bit_count = 0;
			((lzham_symbol_codec*)@this)->m_total_model_updates = 0;
			((lzham_symbol_codec*)@this)->m_mode = 0;
			((lzham_symbol_codec*)@this)->m_total_bits_written = 0;
			((lzham_symbol_codec*)@this)->m_arith_base = 0;
			((lzham_symbol_codec*)@this)->m_arith_value = 0;
			((lzham_symbol_codec*)@this)->m_arith_length = 0;
			((lzham_symbol_codec*)@this)->m_arith_total_bits = 0;
			try_resize_m9x9dy.Invoke(&((lzham_symbol_codec*)@this)->m_output_buf, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			try_resize_m9x9dy.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, 0, grow_hint: false);
			if (ExceptionInfo.Current == null)
			{
				try_resize_tzyfr4.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms, 0, grow_hint: false);
				if (ExceptionInfo.Current == null)
				{
					((lzham_symbol_codec*)@this)->m_pDecode_need_bytes_func = null;
					((lzham_symbol_codec*)@this)->m_pDecode_private_data = null;
					((lzham_symbol_codec*)@this)->m_pSaved_huff_model = null;
					((lzham_symbol_codec*)@this)->m_pSaved_model = null;
					((lzham_symbol_codec*)@this)->m_saved_node_index = 0;
				}
			}
		}
	}
}
