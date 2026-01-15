using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4quasi_adaptive_huffman_data_model@lzham@@QEAAAEAU01@AEBU01@@Z")]
[DemangledName("public: struct lzham::quasi_adaptive_huffman_data_model & __cdecl lzham::quasi_adaptive_huffman_data_model::operator=(struct lzham::quasi_adaptive_huffman_data_model const &)")]
internal static partial class quasi_adaptive_huffman_data_model_Assignment
{
	[return: NativeType("struct lzham::quasi_adaptive_huffman_data_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("struct lzham::quasi_adaptive_huffman_data_model const &")] void* parameter_1)
	{
		raw_quasi_adaptive_huffman_data_model_Assignment.Invoke(@this, parameter_1);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((lzham_quasi_adaptive_huffman_data_model*)@this)->field_1, &((lzham_quasi_adaptive_huffman_data_model*)parameter_1)->field_1, 24L, isVolatile: false);
			return @this;
		}
	}
}
