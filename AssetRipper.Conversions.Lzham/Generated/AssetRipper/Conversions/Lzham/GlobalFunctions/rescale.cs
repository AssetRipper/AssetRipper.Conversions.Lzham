using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?rescale@raw_quasi_adaptive_huffman_data_model@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::raw_quasi_adaptive_huffman_data_model::rescale(void)")]
internal static partial class rescale
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		int num = 0;
		unchecked
		{
			for (int i = 0; (uint)i < (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms; i++)
			{
				int num2;
				checked
				{
					num2 = unchecked((ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, i))) + 1 >> 1;
				}
				num += num2;
				*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, i) = (short)num2;
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count = num;
		}
	}
}
