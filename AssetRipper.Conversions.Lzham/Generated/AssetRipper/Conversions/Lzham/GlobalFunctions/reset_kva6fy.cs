using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::reset(void)")]
[CleanName("reset")]
internal static partial class reset_kva6fy
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms == 0)
			{
				return true;
			}
			sbyte b = 0;
			if (size_r8uza7.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq) != 0)
			{
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = 0;
				for (int i = 0; (uint)i < (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms; i++)
				{
					int num = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq, i));
					*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, i) = (short)num;
					((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle += num;
				}
			}
			else
			{
				for (int j = 0; (uint)j < (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms; j++)
				{
					*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, j) = 1;
				}
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms;
				b = 1;
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count = 0;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = 0;
			bool flag = update_tables.Invoke(sym_freq_all_ones: (b & 1) == 1, @this: @this, force_update_cycle: ((uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle >= 16u) ? 16 : ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			return true;
		}
	}
}
