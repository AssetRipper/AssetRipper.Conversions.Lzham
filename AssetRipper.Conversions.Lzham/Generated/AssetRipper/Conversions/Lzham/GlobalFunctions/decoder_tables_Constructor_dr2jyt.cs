using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0decoder_tables@prefix_coding@lzham@@QEAA@AEBV012@@Z")]
[DemangledName("public: __cdecl lzham::prefix_coding::decoder_tables::decoder_tables(class lzham::prefix_coding::decoder_tables const &)")]
[CleanName("decoder_tables_Constructor")]
internal static partial class decoder_tables_Constructor_dr2jyt
{
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::prefix_coding::decoder_tables const &")] void* other)
	{
		unchecked
		{
			((lzham_prefix_coding_decoder_tables*)@this)->m_table_shift = 0;
			((lzham_prefix_coding_decoder_tables*)@this)->m_table_max_code = 0;
			((lzham_prefix_coding_decoder_tables*)@this)->m_decode_start_code_size = 0;
			((lzham_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size = 0;
			((lzham_prefix_coding_decoder_tables*)@this)->m_lookup = null;
			((lzham_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size = 0;
			((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = null;
			decoder_tables_Assignment.Invoke(@this, other);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return @this;
		}
	}
}
