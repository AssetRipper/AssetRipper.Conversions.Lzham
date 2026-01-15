using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_len2_match@search_accelerator@lzham@@QEAAII@Z")]
[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_len2_match(unsigned int)")]
internal static partial class Get_len2_match
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int lookahead_ofs)
	{
		unchecked
		{
			if ((uint)(((lzham_search_accelerator*)@this)->m_fill_lookahead_size - lookahead_ofs) < 2u)
			{
				return 0;
			}
			int num = ((lzham_search_accelerator*)@this)->m_lookahead_pos + lookahead_ofs;
			int num2 = *(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next, num - ((lzham_search_accelerator*)@this)->m_fill_lookahead_pos);
			int num3 = num - num2;
			if (num3 == 0 || (uint)num3 > 2047u || (uint)num3 > (uint)(((lzham_search_accelerator*)@this)->m_cur_dict_size + lookahead_ofs))
			{
				return 0;
			}
			void* ptr = vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, num & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask);
			void* ptr2 = vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, num2 & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask);
			if ((byte)(*(sbyte*)ptr) == (byte)(*(sbyte*)ptr2) && (byte)((sbyte*)ptr)[1] == (byte)((sbyte*)ptr2)[1])
			{
				return num3;
			}
			return 0;
		}
	}
}
