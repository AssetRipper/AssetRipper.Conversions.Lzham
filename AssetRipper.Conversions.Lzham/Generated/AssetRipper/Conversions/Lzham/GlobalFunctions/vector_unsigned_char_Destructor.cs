using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1?$vector@E@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<unsigned char>::~vector<unsigned char>(void)")]
internal static partial class vector_unsigned_char_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_vector*)@this)->m_p == null)
			{
				return;
			}
			destruct_array_4eajvq.Invoke(n: ((lzham_vector*)@this)->m_size, p: ((lzham_vector*)@this)->m_p);
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
