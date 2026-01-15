using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1lzham_decompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzham_decompressor::~lzham_decompressor(void)")]
internal static partial class lzham_decompressor_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzham_decompressor*)@this)->m_dist_lsb_table);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			lzham_quasi_adaptive_huffman_data_model* large_len_table = (lzham_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)@this)->m_large_len_table);
			nint num = (nint)(large_len_table + 2L);
			while (true)
			{
				lzham_quasi_adaptive_huffman_data_model* ptr = (lzham_quasi_adaptive_huffman_data_model*)(num + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
				quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr == large_len_table)
				{
					break;
				}
				num = (nint)ptr;
			}
			lzham_quasi_adaptive_huffman_data_model* rep_len_table = (lzham_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)@this)->m_rep_len_table);
			nint num2 = (nint)(rep_len_table + 2L);
			while (true)
			{
				lzham_quasi_adaptive_huffman_data_model* ptr2 = (lzham_quasi_adaptive_huffman_data_model*)(num2 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
				quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr2);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr2 == rep_len_table)
				{
					break;
				}
				num2 = (nint)ptr2;
			}
			quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzham_decompressor*)@this)->m_main_table);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzham_decompressor*)@this)->m_delta_lit_table);
			if (ExceptionInfo.Current == null)
			{
				quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzham_decompressor*)@this)->m_lit_table);
				if (ExceptionInfo.Current == null)
				{
					symbol_codec_Destructor.Invoke(&((lzham_lzham_decompressor*)@this)->m_codec);
				}
			}
		}
	}
}
