using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init2@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_N_NIIIPEBG@Z")]
[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::init2(bool, unsigned int, unsigned int, unsigned int, unsigned short const *)")]
internal static partial class init2
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms, [NativeType("unsigned int")] int max_update_interval, [NativeType("unsigned int")] int adapt_rate, [NativeType("unsigned short const *")] void* pInitial_sym_freq)
	{
		unchecked
		{
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_encoding = ((((encoding ? 1u : 0u) & 1u) == 1) ? ((sbyte)1) : ((sbyte)0));
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval = (short)max_update_interval;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate = (short)adapt_rate;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = 0;
			bool flag = try_resize_x6c5v6.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, total_syms, grow_hint: false);
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
			if (pInitial_sym_freq != null)
			{
				bool flag2 = try_resize_x6c5v6.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq, total_syms, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					clear_bzp3jp.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					return false;
				}
				llvm_memcpy_p0_p0_i64.Invoke(begin.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq), pInitial_sym_freq, (uint)(total_syms * size_in_bytes_pes8ki.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq)), isVolatile: false);
			}
			bool flag3 = try_resize_m9x9dy.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, total_syms, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				clear_bzp3jp.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				return false;
			}
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms = total_syms;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_decoder_table_bits = (sbyte)minimum_c94n3m.Invoke(((uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms > 8u) ? (1 + ceil_log2i.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms)) : 4, 11);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_encoding & 1) == 1)
			{
				lzham_delete_thmwkf.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables = null;
				bool flag4 = try_resize_x6c5v6.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes, total_syms, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag4)
				{
					clear_bzp3jp.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					return false;
				}
			}
			else if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables == null)
			{
				void* pDecode_tables = lzham_new_6ts7ez.Invoke();
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
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle = (((24u >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms) ? 24 : ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms) + 6) * ((((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval == 0) ? 64 : ((ushort)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_update_interval));
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle = (((uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle >= 32767u) ? 32767 : ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle);
			reset_kva6fy.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return true;
		}
	}
}
