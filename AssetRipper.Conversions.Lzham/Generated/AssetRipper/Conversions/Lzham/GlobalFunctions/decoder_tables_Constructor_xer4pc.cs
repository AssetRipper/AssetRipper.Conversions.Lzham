using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0decoder_tables@prefix_coding@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::prefix_coding::decoder_tables::decoder_tables(void)")]
[CleanName("decoder_tables_Constructor")]
internal static partial class decoder_tables_Constructor_xer4pc
{
	public unsafe static void* Invoke(void* @this)
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
			return @this;
		}
	}
}
