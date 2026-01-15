using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?add_bytes_begin@search_accelerator@lzham@@QEAA_NIPEBE@Z")]
[DemangledName("public: bool __cdecl lzham::search_accelerator::add_bytes_begin(unsigned int, unsigned char const *)")]
internal static partial class add_bytes_begin
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int num_bytes, [NativeType("unsigned char const *")] void* pBytes)
	{
		unchecked
		{
			int num = ((lzham_search_accelerator*)@this)->m_lookahead_pos & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
			llvm_memcpy_p0_p0_i64.Invoke(vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, num), pBytes, (uint)num_bytes, isVolatile: false);
			int num2 = ((65536u >= (uint)((lzham_search_accelerator*)@this)->m_max_dict_size) ? ((lzham_search_accelerator*)@this)->m_max_dict_size : 65536);
			if ((uint)num < (uint)num2)
			{
				llvm_memcpy_p0_p0_i64.Invoke(vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, ((lzham_search_accelerator*)@this)->m_max_dict_size), vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, 0), (uint)num2, isVolatile: false);
			}
			((lzham_search_accelerator*)@this)->m_lookahead_size = num_bytes;
			int num3 = ((lzham_search_accelerator*)@this)->m_max_dict_size - num_bytes;
			((lzham_search_accelerator*)@this)->m_cur_dict_size = (((uint)((lzham_search_accelerator*)@this)->m_cur_dict_size >= (uint)num3) ? num3 : ((lzham_search_accelerator*)@this)->m_cur_dict_size);
			((lzham_search_accelerator*)@this)->m_next_match_ref = 0;
			bool result = find_all_matches.Invoke(@this, num_bytes);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
