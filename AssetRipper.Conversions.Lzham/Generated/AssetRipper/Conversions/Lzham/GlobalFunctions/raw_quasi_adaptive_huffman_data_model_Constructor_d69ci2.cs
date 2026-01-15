using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0raw_quasi_adaptive_huffman_data_model@lzham@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl lzham::raw_quasi_adaptive_huffman_data_model::raw_quasi_adaptive_huffman_data_model(class lzham::raw_quasi_adaptive_huffman_data_model const &)")]
[CleanName("raw_quasi_adaptive_huffman_data_model_Constructor")]
internal static partial class raw_quasi_adaptive_huffman_data_model_Constructor_d69ci2
{
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::raw_quasi_adaptive_huffman_data_model const &")] void* other)
	{
		unchecked
		{
			lzham_vector* initial_sym_freq = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq;
			vector_unsigned_short_Constructor.Invoke(initial_sym_freq);
			lzham_vector* sym_freq = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq;
			vector_unsigned_short_Constructor.Invoke(sym_freq);
			if (ExceptionInfo.Current == null)
			{
				lzham_vector* codes = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes;
				vector_unsigned_short_Constructor.Invoke(codes);
				if (ExceptionInfo.Current == null)
				{
					lzham_vector* code_sizes = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes;
					vector_unsigned_char_Constructor.Invoke(code_sizes);
					if (ExceptionInfo.Current == null)
					{
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables = null;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_decoder_table_bits = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate = 0;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_encoding = 0;
						raw_quasi_adaptive_huffman_data_model_Assignment.Invoke(@this, other);
						if (ExceptionInfo.Current == null)
						{
							return @this;
						}
						ExceptionInfo current = ExceptionInfo.Current;
						ExceptionInfo.Current = null;
						vector_unsigned_char_Destructor.Invoke(code_sizes);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						ExceptionInfo.Current = current;
					}
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					vector_unsigned_short_Destructor.Invoke(codes);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					ExceptionInfo.Current = current2;
				}
				ExceptionInfo current3 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				vector_unsigned_short_Destructor.Invoke(sym_freq);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current3;
			}
			ExceptionInfo current4 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_short_Destructor.Invoke(initial_sym_freq);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current4;
			return null;
		}
	}
}
