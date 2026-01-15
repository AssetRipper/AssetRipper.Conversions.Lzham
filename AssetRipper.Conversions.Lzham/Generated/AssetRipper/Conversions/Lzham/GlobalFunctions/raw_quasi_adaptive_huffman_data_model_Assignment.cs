using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4raw_quasi_adaptive_huffman_data_model@lzham@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class lzham::raw_quasi_adaptive_huffman_data_model & __cdecl lzham::raw_quasi_adaptive_huffman_data_model::operator=(class lzham::raw_quasi_adaptive_huffman_data_model const &)")]
internal static partial class raw_quasi_adaptive_huffman_data_model_Assignment
{
	[return: NativeType("class lzham::raw_quasi_adaptive_huffman_data_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::raw_quasi_adaptive_huffman_data_model const &")] void* rhs)
	{
		assign_7mvy2m.Invoke(@this, rhs);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return @this;
	}
}
