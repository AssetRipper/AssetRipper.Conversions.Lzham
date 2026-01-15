using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?find_len2_matches@search_accelerator@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::search_accelerator::find_len2_matches(void)")]
internal static partial class find_len2_matches
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			if (size_9n9s89.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash) == 0)
			{
				bool flag = try_resize_wakwrt.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash, 4096, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			if ((uint)size_9n9s89.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next) < (uint)((lzham_search_accelerator*)@this)->m_lookahead_size)
			{
				bool flag2 = try_resize_wakwrt.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next, ((lzham_search_accelerator*)@this)->m_lookahead_size, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					return false;
				}
			}
			int num = ((lzham_search_accelerator*)@this)->m_lookahead_pos & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
			int num2 = 0;
			while (num2 < checked(unchecked((lzham_search_accelerator*)@this)->m_lookahead_size - 1))
			{
				int i = hash2_to_12.Invoke((byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, num)), (byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, num + 1))) & 0xFFF;
				int num3 = *(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash, i);
				*(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next, num2) = num3;
				int num4 = ((lzham_search_accelerator*)@this)->m_lookahead_pos + num2;
				*(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash, i) = num4;
				num2 = checked(num2 + 1);
				num++;
			}
			*(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next, ((lzham_search_accelerator*)@this)->m_lookahead_size - 1) = 0;
			return true;
		}
	}
}
