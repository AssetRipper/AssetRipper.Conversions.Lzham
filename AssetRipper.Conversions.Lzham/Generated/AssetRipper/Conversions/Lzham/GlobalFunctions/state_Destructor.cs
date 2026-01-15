using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1state@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::state::~state(void)")]
internal static partial class state_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzcompressor_state*)@this)->field_13);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			lzham_quasi_adaptive_huffman_data_model* field_ = (lzham_quasi_adaptive_huffman_data_model*)(&((lzham_lzcompressor_state*)@this)->field_12);
			nint num = (nint)(field_ + 2L);
			while (true)
			{
				lzham_quasi_adaptive_huffman_data_model* ptr = (lzham_quasi_adaptive_huffman_data_model*)(num + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
				quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr == field_)
				{
					break;
				}
				num = (nint)ptr;
			}
			lzham_quasi_adaptive_huffman_data_model* field_2 = (lzham_quasi_adaptive_huffman_data_model*)(&((lzham_lzcompressor_state*)@this)->field_11);
			nint num2 = (nint)(field_2 + 2L);
			while (true)
			{
				lzham_quasi_adaptive_huffman_data_model* ptr2 = (lzham_quasi_adaptive_huffman_data_model*)(num2 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
				quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr2);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr2 == field_2)
				{
					break;
				}
				num2 = (nint)ptr2;
			}
			quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzcompressor_state*)@this)->field_10);
			if (ExceptionInfo.Current == null)
			{
				quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzcompressor_state*)@this)->field_9);
				if (ExceptionInfo.Current == null)
				{
					quasi_adaptive_huffman_data_model_Destructor.Invoke(&((lzham_lzcompressor_state*)@this)->field_8);
				}
			}
		}
	}
}
