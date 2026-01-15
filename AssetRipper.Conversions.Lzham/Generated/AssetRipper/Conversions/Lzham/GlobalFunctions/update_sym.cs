using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update_sym@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::update_sym(unsigned int)")]
internal static partial class update_sym
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int sym)
	{
		unchecked
		{
			int num = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, sym));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, sym) = (short)(num + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update += -1) == 0)
			{
				bool flag = update_tables.Invoke(@this, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}
	}
}
