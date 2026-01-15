using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?find_matches@search_accelerator@lzham@@QEAAPEAUdict_match@2@I_N@Z")]
[DemangledName("public: struct lzham::dict_match * __cdecl lzham::search_accelerator::find_matches(unsigned int, bool)")]
internal static partial class find_matches
{
	[return: NativeType("struct lzham::dict_match *")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int lookahead_ofs, [NativeType("bool")] bool spin)
	{
		sbyte b = (spin ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			int i = ((lzham_search_accelerator*)@this)->m_lookahead_pos - ((lzham_search_accelerator*)@this)->m_fill_lookahead_pos + lookahead_ofs;
			int num = 0;
			while (true)
			{
				int num2 = *(int*)vector_long_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs, i);
				switch (num2)
				{
				case -2:
					return null;
				case -1:
					num++;
					if ((b & 1) == 1 && (uint)num < 1000u)
					{
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
						lzham_yield_processor.Invoke();
					}
					else
					{
						num = 1000;
						lzham_sleep.Invoke(1);
					}
					break;
				default:
					return vector_struct_lzham_dict_match_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_matches, num2);
				}
			}
		}
	}
}
