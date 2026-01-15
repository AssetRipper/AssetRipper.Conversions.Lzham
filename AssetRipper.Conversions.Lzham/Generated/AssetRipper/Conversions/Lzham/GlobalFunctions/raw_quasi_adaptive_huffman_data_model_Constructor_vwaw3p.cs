using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0raw_quasi_adaptive_huffman_data_model@lzham@@QEAA@_NIII@Z")]
[DemangledName("public: __cdecl lzham::raw_quasi_adaptive_huffman_data_model::raw_quasi_adaptive_huffman_data_model(bool, unsigned int, unsigned int, unsigned int)")]
[CleanName("raw_quasi_adaptive_huffman_data_model_Constructor")]
internal static partial class raw_quasi_adaptive_huffman_data_model_Constructor_vwaw3p
{
	public unsafe static void* Invoke(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms, [NativeType("unsigned int")] int max_update_interval, [NativeType("unsigned int")] int adapt_rate)
	{
		sbyte b = (encoding ? ((sbyte)1) : ((sbyte)0));
		lzham_vector* initial_sym_freq;
		lzham_vector* sym_freq;
		lzham_vector* codes;
		unchecked
		{
			initial_sym_freq = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq;
			vector_unsigned_short_Constructor.Invoke(initial_sym_freq);
			sym_freq = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq;
			vector_unsigned_short_Constructor.Invoke(sym_freq);
			if (ExceptionInfo.Current == null)
			{
				codes = &((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes;
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
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval = (short)max_update_interval;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate = (short)adapt_rate;
						((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_encoding = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
						if (total_syms != 0)
						{
							init2.Invoke(@this, (b & 1) == 1, total_syms, max_update_interval, adapt_rate, null);
							if (ExceptionInfo.Current != null)
							{
								ExceptionInfo current = ExceptionInfo.Current;
								ExceptionInfo.Current = null;
								vector_unsigned_char_Destructor.Invoke(code_sizes);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								ExceptionInfo.Current = current;
								goto IL_0136;
							}
						}
						return @this;
					}
					goto IL_0136;
				}
				goto IL_015e;
			}
			goto IL_0186;
		}
		IL_0136:
		ExceptionInfo current2 = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_short_Destructor.Invoke(codes);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		ExceptionInfo.Current = current2;
		goto IL_015e;
		IL_015e:
		ExceptionInfo current3 = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_short_Destructor.Invoke(sym_freq);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		ExceptionInfo.Current = current3;
		goto IL_0186;
		IL_0186:
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
