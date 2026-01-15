using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?assign@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NAEBV12@@Z")]
[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::assign(class lzham::raw_quasi_adaptive_huffman_data_model const &)")]
[CleanName("assign")]
internal static partial class assign_7mvy2m
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class lzham::raw_quasi_adaptive_huffman_data_model const &")] void* rhs)
	{
		if (@this == rhs)
		{
			return true;
		}
		unchecked
		{
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_total_syms;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_max_cycle;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_update_cycle;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_symbols_until_update;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_total_count;
			vector_unsigned_short_Assignment.Invoke(other: &((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_sym_freq, @this: &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			vector_unsigned_short_Assignment.Invoke(other: &((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_initial_sym_freq, @this: &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			vector_unsigned_short_Assignment.Invoke(other: &((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_codes, @this: &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			vector_unsigned_char_Assignment.Invoke(other: &((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_code_sizes, @this: &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_pDecode_tables != null)
			{
				if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables != null)
				{
					bool flag = assign_e8jmuj.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables, ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_pDecode_tables);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag)
					{
						clear_bzp3jp.Invoke(@this);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						return false;
					}
				}
				else
				{
					void* pDecode_tables = lzham_new_qv8q5m.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_pDecode_tables);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables = pDecode_tables;
					if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables == null)
					{
						clear_bzp3jp.Invoke(@this);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						return false;
					}
				}
			}
			else if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables != null)
			{
				lzham_delete_thmwkf.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables = null;
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_decoder_table_bits = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_decoder_table_bits;
			bool num = (((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_encoding & 1) == 1;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_encoding = (num ? ((sbyte)1) : ((sbyte)0));
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_max_update_interval;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate = ((lzham_raw_quasi_adaptive_huffman_data_model*)rhs)->m_adapt_rate;
			return true;
		}
	}
}
