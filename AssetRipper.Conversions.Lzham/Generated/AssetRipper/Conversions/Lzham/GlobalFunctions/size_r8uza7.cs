using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?size@?$vector@G@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned short>::size(void) const")]
[CleanName("size")]
internal static partial class size_r8uza7
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_size;
	}
}
