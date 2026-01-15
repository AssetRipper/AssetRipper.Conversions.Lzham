using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_match_len@search_accelerator@lzham@@QEBAIIHII@Z")]
[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_match_len(unsigned int, int, unsigned int, unsigned int) const")]
internal static partial class Get_match_len
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int lookahead_ofs, [NativeType("int")] int dist, [NativeType("unsigned int")] int max_match_len, [NativeType("unsigned int")] int start_match_len)
	{
		unchecked
		{
			if (dist > ((lzham_search_accelerator*)@this)->m_cur_dict_size + lookahead_ofs)
			{
				return 0;
			}
			int i = (((lzham_search_accelerator*)@this)->m_lookahead_pos + lookahead_ofs - dist) & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
			int i2 = (((lzham_search_accelerator*)@this)->m_lookahead_pos + lookahead_ofs) & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
			void* ptr = vector_unsigned_char_Operator_7ma9vz.Invoke(&((lzham_search_accelerator*)@this)->m_dict, i);
			void* ptr2 = vector_unsigned_char_Operator_7ma9vz.Invoke(&((lzham_search_accelerator*)@this)->m_dict, i2);
			int j;
			for (j = start_match_len; (uint)j < (uint)max_match_len && (byte)((sbyte*)ptr)[(uint)j] == (byte)((sbyte*)ptr2)[(uint)j]; j++)
			{
			}
			return j;
		}
	}
}
