using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_update_rate@raw_quasi_adaptive_huffman_data_model@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::raw_quasi_adaptive_huffman_data_model::reset_update_rate(void)")]
[CleanName("reset_update_rate")]
internal static partial class reset_update_rate_r8jzfi
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			int num = ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle - ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count += num;
			int num2 = 0;
			for (int i = 0; (uint)i < (uint)size_r8uza7.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq); i++)
			{
				num2 += (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, i));
			}
			if ((uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count > (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms)
			{
				rescale.Invoke(@this);
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = ((8u >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle) ? ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle : 8));
		}
	}
}
