using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::vector<struct lzham::lzcompressor::lzpriced_decision>(void)")]
internal static partial class vector_struct_lzham_lzcompressor_lzpriced_decision_Constructor
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
