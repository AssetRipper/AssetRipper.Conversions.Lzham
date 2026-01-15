using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1?$vector@Udict_match@lzham@@@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<struct lzham::dict_match>::~vector<struct lzham::dict_match>(void)")]
internal static partial class vector_struct_lzham_dict_match_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_vector*)@this)->m_p == null)
			{
				return;
			}
			destruct_array_j4mhvj.Invoke(n: ((lzham_vector*)@this)->m_size, p: ((lzham_vector*)@this)->m_p);
			if (ExceptionInfo.Current == null)
			{
				lzham_free.Invoke(((lzham_vector*)@this)->m_p);
				if (ExceptionInfo.Current == null)
				{
					return;
				}
			}
			ExceptionInfo.Current = null;
			std_terminate.Invoke();
			throw null;
		}
	}
}
