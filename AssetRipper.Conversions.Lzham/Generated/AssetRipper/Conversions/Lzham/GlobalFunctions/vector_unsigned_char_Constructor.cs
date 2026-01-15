using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0?$vector@E@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<unsigned char>::vector<unsigned char>(void)")]
internal static partial class vector_unsigned_char_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((lzham_vector*)@this)->m_p = null;
			((lzham_vector*)@this)->m_size = 0;
			((lzham_vector*)@this)->m_capacity = 0;
			return @this;
		}
	}
}
