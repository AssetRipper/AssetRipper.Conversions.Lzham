using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ptr@?$vector@E@lzham@@QEBAPEBEXZ")]
[DemangledName("public: unsigned char const * __cdecl lzham::vector<unsigned char>::get_ptr(void) const")]
[CleanName("Get_ptr")]
internal static partial class Get_ptr_pyhvtd
{
	[return: NativeType("unsigned char const *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_p;
	}
}
