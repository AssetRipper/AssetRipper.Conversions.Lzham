using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4state@lzcompressor@lzham@@QEAAAEAV012@AEBV012@@Z")]
[DemangledName("public: class lzham::lzcompressor::state & __cdecl lzham::lzcompressor::state::operator=(class lzham::lzcompressor::state const &)")]
internal static partial class state_Assignment
{
	[return: NativeType("class lzham::lzcompressor::state &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::lzcompressor::state const &")] void* parameter_1)
	{
		llvm_memcpy_p0_p0_i64.Invoke(@this, parameter_1, 24L, isVolatile: false);
		unchecked
		{
			((lzham_lzcompressor_state*)@this)->field_1 = ((lzham_lzcompressor_state*)parameter_1)->field_1;
			for (long num = 0L; num != 12L; num++)
			{
				adaptive_bit_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)num * sizeof(lzham_adaptive_bit_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_2) + (nint)num * sizeof(lzham_adaptive_bit_model));
			}
			for (long num2 = 0L; num2 != 12L; num2++)
			{
				adaptive_bit_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)num2 * sizeof(lzham_adaptive_bit_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_3) + (nint)num2 * sizeof(lzham_adaptive_bit_model));
			}
			for (long num3 = 0L; num3 != 12L; num3++)
			{
				adaptive_bit_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)num3 * sizeof(lzham_adaptive_bit_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_4) + (nint)num3 * sizeof(lzham_adaptive_bit_model));
			}
			for (long num4 = 0L; num4 != 12L; num4++)
			{
				adaptive_bit_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)num4 * sizeof(lzham_adaptive_bit_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_5) + (nint)num4 * sizeof(lzham_adaptive_bit_model));
			}
			for (long num5 = 0L; num5 != 12L; num5++)
			{
				adaptive_bit_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)num5 * sizeof(lzham_adaptive_bit_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_6) + (nint)num5 * sizeof(lzham_adaptive_bit_model));
			}
			for (long num6 = 0L; num6 != 12L; num6++)
			{
				adaptive_bit_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)num6 * sizeof(lzham_adaptive_bit_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_7) + (nint)num6 * sizeof(lzham_adaptive_bit_model));
			}
			quasi_adaptive_huffman_data_model_Assignment.Invoke(&((lzham_lzcompressor_state*)@this)->field_8, &((lzham_lzcompressor_state*)parameter_1)->field_8);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			quasi_adaptive_huffman_data_model_Assignment.Invoke(&((lzham_lzcompressor_state*)@this)->field_9, &((lzham_lzcompressor_state*)parameter_1)->field_9);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			quasi_adaptive_huffman_data_model_Assignment.Invoke(&((lzham_lzcompressor_state*)@this)->field_10, &((lzham_lzcompressor_state*)parameter_1)->field_10);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			for (long num7 = 0L; num7 != 2L; num7++)
			{
				quasi_adaptive_huffman_data_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (nint)num7 * sizeof(lzham_quasi_adaptive_huffman_data_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_11) + (nint)num7 * sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
			}
			for (long num8 = 0L; num8 != 2L; num8++)
			{
				quasi_adaptive_huffman_data_model_Assignment.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (nint)num8 * sizeof(lzham_quasi_adaptive_huffman_data_model), (byte*)(&((lzham_lzcompressor_state*)parameter_1)->field_12) + (nint)num8 * sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
			}
			quasi_adaptive_huffman_data_model_Assignment.Invoke(&((lzham_lzcompressor_state*)@this)->field_13, &((lzham_lzcompressor_state*)parameter_1)->field_13);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return @this;
		}
	}
}
