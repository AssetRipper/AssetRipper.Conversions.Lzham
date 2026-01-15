using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@raw_quasi_adaptive_huffman_data_model@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::raw_quasi_adaptive_huffman_data_model::clear(void)")]
[CleanName("clear")]
internal static partial class clear_bzp3jp
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			clear_nj6f5j.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			clear_nj6f5j.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			clear_nj6f5j.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			clear_tzajca.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_decoder_table_bits = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count = 0;
			if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables != null)
			{
				lzham_delete_thmwkf.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables = null;
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate = 0;
		}
	}
}
