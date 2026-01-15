using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1raw_quasi_adaptive_huffman_data_model@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::raw_quasi_adaptive_huffman_data_model::~raw_quasi_adaptive_huffman_data_model(void)")]
internal static partial class raw_quasi_adaptive_huffman_data_model_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables != null)
			{
				lzham_delete_thmwkf.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current != null)
				{
					ExceptionInfo.Current = null;
					std_terminate.Invoke();
					throw null;
				}
			}
			vector_unsigned_char_Destructor.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_short_Destructor.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes);
			if (ExceptionInfo.Current == null)
			{
				vector_unsigned_short_Destructor.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq);
				if (ExceptionInfo.Current == null)
				{
					vector_unsigned_short_Destructor.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_initial_sym_freq);
				}
			}
		}
	}
}
