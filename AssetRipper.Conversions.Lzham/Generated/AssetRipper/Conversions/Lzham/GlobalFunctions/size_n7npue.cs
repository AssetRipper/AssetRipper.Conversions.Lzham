using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::size(void) const")]
[CleanName("size")]
internal static partial class size_n7npue
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_size;
	}
}
