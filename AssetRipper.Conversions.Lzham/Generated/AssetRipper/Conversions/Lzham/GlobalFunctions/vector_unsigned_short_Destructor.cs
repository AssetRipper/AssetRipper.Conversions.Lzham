using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1?$vector@G@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<unsigned short>::~vector<unsigned short>(void)")]
internal static partial class vector_unsigned_short_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_vector*)@this)->m_p == null)
			{
				return;
			}
			destruct_array_hna8pw.Invoke(n: ((lzham_vector*)@this)->m_size, p: ((lzham_vector*)@this)->m_p);
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
