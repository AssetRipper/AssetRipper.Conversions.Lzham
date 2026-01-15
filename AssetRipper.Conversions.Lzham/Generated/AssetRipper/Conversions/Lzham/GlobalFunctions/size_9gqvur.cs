using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::size(void) const")]
[CleanName("size")]
internal static partial class size_9gqvur
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_size;
	}
}
