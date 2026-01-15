using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode@symbol_codec@lzham@@QEAA_NIAEAUquasi_adaptive_huffman_data_model@2@@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::encode(unsigned int, struct lzham::quasi_adaptive_huffman_data_model &)")]
[CleanName("encode")]
internal static partial class encode_gbd3f5
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int sym, [NativeType("struct lzham::quasi_adaptive_huffman_data_model &")] void* model)
	{
		unchecked
		{
			bool flag = record_put_bits.Invoke(num_bits: (byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_code_sizes, sym)), @this: @this, bits: (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_codes, sym)));
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			int num = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_sym_freq, sym));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_sym_freq, sym) = (short)(num + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_symbols_until_update += -1) == 0)
			{
				((lzham_symbol_codec*)@this)->m_total_model_updates++;
				bool flag2 = update_tables.Invoke(model, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					return false;
				}
			}
			return true;
		}
	}
}
