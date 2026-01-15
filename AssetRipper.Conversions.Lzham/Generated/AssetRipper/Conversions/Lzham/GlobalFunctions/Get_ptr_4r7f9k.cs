using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ptr@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAAPEAUlzdecision@lzcompressor@2@XZ")]
[DemangledName("public: struct lzham::lzcompressor::lzdecision * __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::get_ptr(void)")]
[CleanName("Get_ptr")]
internal static partial class Get_ptr_4r7f9k
{
	[return: NativeType("struct lzham::lzcompressor::lzdecision *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_p;
	}
}
